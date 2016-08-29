using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeiboFollowingBackup
{
    public class FollowerProfile
    {
        public string UID { get; set; }
        public string NickName { get; set; }
        public DateTime ProcessTime { get; set; }
        public List<FollowerItem> FollowerInfo { get; set; }
    }
}
