using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Awesomium.Core;
using Awesomium.Windows.Forms;
using Newtonsoft.Json;
using Timer = System.Timers.Timer;

namespace WeiboFollowingBackup
{
    public partial class MainForm : Form
    {
        private SynchronizationContext uiContext;
        private string currentNickName;
        private string currentUID;
        private bool isLogged = false;
        private FollowerProfile profile;

        private static readonly Random getrandom = new Random();
        private static readonly object syncLock = new object();

        private static readonly string webSessionStorageLocation =
            Path.Combine(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location), "session");

        private static string cookieDBLocation = Path.Combine(webSessionStorageLocation, "Cookies");
        private static string cookieSUP;

        private string followingPageUri => $"http://weibo.com/{currentUID}/follow";
        public MainForm()
        {
            InitializeComponent();
            WebCore.Initialize(new WebConfig()
            {
                RemoteDebuggingPort = 2222
            });
            uiContext = SynchronizationContext.Current;
            var session = WebCore.CreateWebSession(
                webSessionStorageLocation, 
                WebPreferences.Default);
            WebControl.WebSession = session;

            WebControl.LoadingFrame += WebControl_LoadingFrame;
            WebControl.LoadingFrameComplete += WebControl_LoadingFrameComplete_Global;
            
//            WebControl.WebSession.SetCookie(new Uri("http://weibo.com"), File.ReadAllText("cookie.txt"), false, true);

            NavigateTo("http://weibo.com");
            WebControl.LoadingFrameComplete += WebControl_LoadingFrameComplete_Index;
        }

        private void ButtonNavigate_Click(object sender, EventArgs e)
        {
            var uriText = TextBoxUri.Text;
            NavigateTo(uriText);
        }

        private void WebControl_LoadingFrameComplete_Index(object sender, FrameEventArgs e)
        {
            if (e.Url.AbsoluteUri.Contains("passport.weibo.com")) return;

            dynamic config = (JSObject)WebControl.ExecuteJavascriptWithResult("$CONFIG");
            if (config.nick.ToString() == "undefined"|| config.nick.ToString()=="System.Object") return;
            WebControl.LoadingFrameComplete -= WebControl_LoadingFrameComplete_Index;
            currentNickName = config.nick;
            currentUID = config.uid;
            isLogged = true;
            MessageBox.Show($@"已登录。用户名:'{currentNickName}', 用户ID:{currentUID}");
        }

        private void NavigateTo(string uri)
        {
            if (!uri.StartsWith("http://") && !uri.StartsWith("https://"))
                uri = "http://" + uri;
            try
            {
                WebControl.Source = new Uri(uri);
            }
            catch (Exception)
            {
                MessageBox.Show(@"请输入正确格式的地址");
            }
            TextBoxUri.Text = uri;
        }

        private void WebControl_LoadingFrame(object sender, LoadingFrameEventArgs e)
        {
            TextBoxStatus.Text = @"加载页面中，请稍等。如果长时间没有响应。请重新载入页面";
        }

        private void WebControl_LoadingFrameComplete_Global(object sender, Awesomium.Core.FrameEventArgs e)
        {
            //if (!e.IsMainFrame) return;
            if (e.Url.AbsoluteUri.Contains("passport.weibo.com")) return;
            TextBoxStatus.Text = isLogged ? $"已登陆。用户名:'{currentNickName}', 用户ID:'{currentUID}'" : @"已就绪";
        }

        private void ButtonStartBackup_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"现在开始获取关注者信息，在弹出完成窗口之前请勿进行其他操作。");
            NavigateTo(followingPageUri);
            GridViewFollow.Rows.Clear();
            WebControl.LoadingFrameComplete += WebControl_LoadingFrameComplete_Following;
        }

        private void WebControl_LoadingFrameComplete_Following(object sender, FrameEventArgs e)
        {
            var flag = e.Url.AbsoluteUri == followingPageUri || e.Url.AbsoluteUri.Contains("myfollow");
            if (flag == false) return;
            dynamic modInfoList = (JSObject)WebControl.ExecuteJavascriptWithResult("document.getElementsByClassName('mod_info')");
            for (var i = 0; i < modInfoList.length; i++)
            {
                var modInfo = modInfoList[i];
                var followerUri = (string)modInfo.getElementsByTagName("a")[0].href.ToString();
                if(followerUri.Contains("weibo.cn/pages/")) continue;
                var followerNickname = (string) modInfo.getElementsByTagName("a")[0].textContent;
//                var followerUid = followerUri.Split('/').Last().Split('?').First();
                var followerFriendlyUid = followerUri.Split('/').Last().Split('?').First();
                var followerUid = ((string)modInfo.getElementsByTagName("a")[0].getAttribute("usercard")).Split('=').Last();
                // add it to grid view
                GridViewFollow.Rows.Add(true, followerFriendlyUid, followerUid, followerNickname, followerUri);
            }
            var h =WebControl.ExecuteJavascriptWithResult(
                    "document.getElementsByClassName('page next S_txt1 S_line1')[0].href");
            if (!string.IsNullOrEmpty(h))
            {
                Thread.Sleep(100);
                WebControl.ExecuteJavascriptWithResult(
                    "document.getElementsByClassName('page next S_txt1 S_line1')[0].click()");
            }
            else
            {
                MessageBox.Show(@"关注者读取完毕，请保存");
                WebControl.LoadingFrameComplete -= WebControl_LoadingFrameComplete_Following;
            }
        }
        

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            var outputFile = new SaveFileDialog()
            {
                Filter = @"关注者数据文件 (*.follow)|*.follow",
                FileName = $"{currentUID}-{currentNickName}-{DateTime.Now.Year}-{DateTime.Now.Month}-{DateTime.Now.Day}.follow"
            };
            var selectResult = outputFile.ShowDialog();
            if (selectResult == DialogResult.OK)
            {
                // save to file
                var content = GridViewFollow.Rows.Cast<DataGridViewRow>()
                    .Where(row=>(bool)row.Cells[0].Value)
                    .Select(row=>new FollowerItem()
                    {
                        FriendlyUID = (string)row.Cells[1].Value,
                        UID = (string)row.Cells[2].Value,
                        NickName = (string)row.Cells[3].Value,
                        UserUri = (string)row.Cells[4].Value
                    }).ToList();
                var result = new FollowerProfile()
                {
                    UID = currentUID,
                    NickName = currentNickName,
                    ProcessTime = DateTime.Now,
                    FollowerInfo = content
                };
                File.WriteAllText(outputFile.FileName, JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            LoadFollowerProfile(outputFile.FileName);
        }

        private void LoadFollowerProfile(string profilePath)
        {
            profile = JsonConvert.DeserializeObject<FollowerProfile>(File.ReadAllText(profilePath));
        }

        private void ButtonLoadFollowerProfile_Click(object sender, EventArgs e)
        {
            var inputFile = new OpenFileDialog()
            {
                Filter = @"关注者数据文件 (*.follow)|*.follow",
                FileName = $"{currentUID}-{currentNickName}-{DateTime.Now.Year}-{DateTime.Now.Month}-{DateTime.Now.Day}.follow"
            };
            var selectResult = inputFile.ShowDialog();
            if (selectResult == DialogResult.OK)
            {
                LoadFollowerProfile(inputFile.FileName);

                // fill out grid view
                profile.FollowerInfo.ForEach(item =>
                {
                    GridViewFollowerLoad.Rows.Add(true, item.UID, item.FriendlyUID, item.NickName);
                });
            }
        }

        private void ButtonStartRestore_Click(object sender, EventArgs e)
        {
            // start to insert
            var content = GridViewFollowerLoad.Rows.Cast<DataGridViewRow>()
                .Select(row => row.Cells).Where(row => (bool)row[0].Value).ToList();
            var cookie = WebControl.ExecuteJavascriptWithResult("document.cookie;").ToString();
            //                .Where(row => (bool) row.Cells[0].Value).ToList();
            var task = Task.Run(() =>
            {
                content.ForEach(item =>
                {
                    var uid = (string)item[1].Value;
                    var nikeName = (string)item[3].Value;
                    try
                    {
                        
                        // post request balabala
                        if (PostFollowRequestByUid(uid, nikeName, cookie))
                        {
                            RemoveRowFromGridViewByUID(uid);
                        }
                        Thread.Sleep(1000);
                    }
                    catch (TimeoutException error)
                    {
                        uiContext.Post(s =>
                        {
                            TextBoxLog.AppendText($"关注用户失败：{nikeName}(UID={uid}),超时");
                            TextBoxLog.AppendText(Environment.NewLine);
                        }, null);
                    }
                });

                if (GridViewFollowerLoad.Rows.Cast<DataGridViewRow>().Count(row => (bool) row.Cells[0].Value) > 0)
                {
                    MessageBox.Show(@"一部分关注者未恢复成功，请点击“开始恢复关注者数据”以重新恢复");
                }
                else
                {
                    MessageBox.Show(@"列表中的全部关注者已回复");
                }
            });
            
        }

        private bool PostFollowRequestByUid(string uid, string nikeName, string cookie)
        {
            
            var param =
                $"uid={uid}&objectid=&f=1&extra=&refer_sort=&refer_flag=1005050001_&location=page_100206_home&oid={uid}&wforce=1&nogroup=false&fnick={Uri.EscapeDataString(nikeName)}&refer_lflag=&_t=0";
            byte[] buf = Encoding.UTF8.GetBytes(param);
            var unixTimestamp = (Int32)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
//            var cookie = File.ReadAllText("cookie.txt");
//            File.WriteAllText("cookie.txt", cookie);
            var uri = $"http://weibo.com/aj/f/followed?ajwvr=6&__rnd={unixTimestamp}{GetRandomNumber(101,998)}";
            HttpWebRequest request = (HttpWebRequest) WebRequest.Create(uri);
            request.Method = WebRequestMethods.Http.Post;
            request.Accept = "*/*";
            request.UserAgent = @"Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/52.0.2743.116 Safari/537.36";
            request.Referer = "http://weibo.com/";
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = buf.Length;
            
            request.Headers.Add("Accept-Encoding", "gzip,deflate");
            request.Headers.Add("Accept-Language", "zh-CN,zh;q=0.8,zh-TW;q=0.6,en;q=0.4,ja;q=0.2");
            request.Headers.Add("X-Requested-With: XMLHttpRequest");
            request.Headers.Add("Origin", "http://weibo.com");
            request.Headers.Add("Cookie", $"{cookie}; SUB={GetCookieSUB()}");

            request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
            request.Timeout = 30*1000;
            Stream stream = request.GetRequestStream();
            stream.Write(buf, 0, buf.Length);
            
            
            var httpWebResponse = (HttpWebResponse) request.GetResponse();
            var responseJsonStr = new StreamReader(httpWebResponse.GetResponseStream()).ReadToEnd();
            httpWebResponse.Close();
            dynamic responseJson = JsonConvert.DeserializeObject(responseJsonStr);
            
            if (responseJson.code == "100000")
            {
                uiContext.Post(s =>
                {
                    TextBoxLog.AppendText($"关注用户成功：{nikeName}(UID={uid})");
                    TextBoxLog.AppendText(Environment.NewLine);
                }, null);
                return true;
            }
            else
            {
                uiContext.Post(s =>
                {
                    TextBoxLog.AppendText($"关注用户失败：{nikeName}(UID={uid}),状态码：{responseJson.code}");
                    TextBoxLog.AppendText(Environment.NewLine);
                }, null);
                return false;
            }
        }

        private static string GetCookieSUB(bool refresh=false)
        {
            if (refresh || string.IsNullOrEmpty(cookieSUP))
            {
                SQLiteConnection conn = new SQLiteConnection($"Data Source ='{cookieDBLocation}'");
                conn.Open();
                var querySql = @"SELECT value FROM cookies where name='SUB' and host_key='.weibo.com'";
                var command = new SQLiteCommand(conn) {CommandText = querySql};
                var reader = command.ExecuteReader();
                if (reader.Read())
                {
                    cookieSUP = reader.GetString(0);
                }
            }
            return cookieSUP;
        }

        public static int GetRandomNumber(int min, int max)
        {
            lock (syncLock)
            { // synchronize
                return getrandom.Next(min, max);
            }
        }

        private void RemoveRowFromGridViewByUID(string uid)
        {
            for (var idx = 0; idx < GridViewFollowerLoad.RowCount; idx++)
            {
                var row = GridViewFollowerLoad.Rows[idx];
                if (uid == (string) row.Cells[1].Value)
                {
                    uiContext.Post(s =>
                    {
                        GridViewFollowerLoad.Rows.Remove(row);
                    }, null);
                }
            }
        }
    }
}
