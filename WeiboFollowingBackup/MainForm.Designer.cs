namespace WeiboFollowingBackup
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.TextBoxUri = new System.Windows.Forms.TextBox();
            this.ButtonNavigate = new System.Windows.Forms.Button();
            this.WebControl = new Awesomium.Windows.Forms.WebControl(this.components);
            this.TextBoxStatus = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.GridViewFollow = new System.Windows.Forms.DataGridView();
            this.ButtonStartBackup = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.IsSave = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.FriendlyUID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NickName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserPageUri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ButtonLoadFollowerProfile = new System.Windows.Forms.Button();
            this.GridViewFollowerLoad = new System.Windows.Forms.DataGridView();
            this.ButtonStartRestore = new System.Windows.Forms.Button();
            this.IsRestore = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.LoadUID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoadFriendlyUID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoadUserNickName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.TextBoxLog = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewFollow)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewFollowerLoad)).BeginInit();
            this.tableLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 500F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tabControl1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1116, 591);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.WebControl, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.TextBoxStatus, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(607, 583);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel3.Controls.Add(this.TextBoxUri, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.ButtonNavigate, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(601, 26);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // TextBoxUri
            // 
            this.TextBoxUri.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBoxUri.Location = new System.Drawing.Point(3, 3);
            this.TextBoxUri.Name = "TextBoxUri";
            this.TextBoxUri.Size = new System.Drawing.Size(545, 20);
            this.TextBoxUri.TabIndex = 0;
            this.TextBoxUri.Text = "http://weibo.com";
            // 
            // ButtonNavigate
            // 
            this.ButtonNavigate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonNavigate.Location = new System.Drawing.Point(554, 3);
            this.ButtonNavigate.Name = "ButtonNavigate";
            this.ButtonNavigate.Size = new System.Drawing.Size(44, 20);
            this.ButtonNavigate.TabIndex = 1;
            this.ButtonNavigate.Text = "Go";
            this.ButtonNavigate.UseVisualStyleBackColor = true;
            this.ButtonNavigate.Click += new System.EventHandler(this.ButtonNavigate_Click);
            // 
            // WebControl
            // 
            this.WebControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WebControl.Location = new System.Drawing.Point(3, 35);
            this.WebControl.Size = new System.Drawing.Size(601, 522);
            this.WebControl.Source = new System.Uri("about:blank", System.UriKind.Absolute);
            this.WebControl.TabIndex = 1;
            // 
            // TextBoxStatus
            // 
            this.TextBoxStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBoxStatus.Location = new System.Drawing.Point(3, 563);
            this.TextBoxStatus.Name = "TextBoxStatus";
            this.TextBoxStatus.ReadOnly = true;
            this.TextBoxStatus.Size = new System.Drawing.Size(601, 20);
            this.TextBoxStatus.TabIndex = 2;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(618, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(494, 583);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel4);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(386, 557);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "说明";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(380, 551);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(374, 275);
            this.label1.TabIndex = 0;
            this.label1.Text = "使用步骤\r\n1. 在左侧浏览器窗口登陆你的微博账号\r\n2. 当弹出窗口显示已登录后，选择上方选项卡";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ButtonSave);
            this.tabPage2.Controls.Add(this.GridViewFollow);
            this.tabPage2.Controls.Add(this.ButtonStartBackup);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(486, 557);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "备份关注";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ButtonSave
            // 
            this.ButtonSave.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ButtonSave.Location = new System.Drawing.Point(3, 531);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(480, 23);
            this.ButtonSave.TabIndex = 2;
            this.ButtonSave.Text = "保存关注者数据";
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // GridViewFollow
            // 
            this.GridViewFollow.AllowUserToAddRows = false;
            this.GridViewFollow.AllowUserToDeleteRows = false;
            this.GridViewFollow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewFollow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IsSave,
            this.FriendlyUID,
            this.UID,
            this.NickName,
            this.UserPageUri});
            this.GridViewFollow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridViewFollow.Location = new System.Drawing.Point(3, 26);
            this.GridViewFollow.Name = "GridViewFollow";
            this.GridViewFollow.Size = new System.Drawing.Size(480, 528);
            this.GridViewFollow.TabIndex = 1;
            // 
            // ButtonStartBackup
            // 
            this.ButtonStartBackup.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonStartBackup.Location = new System.Drawing.Point(3, 3);
            this.ButtonStartBackup.Name = "ButtonStartBackup";
            this.ButtonStartBackup.Size = new System.Drawing.Size(480, 23);
            this.ButtonStartBackup.TabIndex = 0;
            this.ButtonStartBackup.Text = "开始备份关注者数据";
            this.ButtonStartBackup.UseVisualStyleBackColor = true;
            this.ButtonStartBackup.Click += new System.EventHandler(this.ButtonStartBackup_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tableLayoutPanel5);
            this.tabPage3.Controls.Add(this.ButtonStartRestore);
            this.tabPage3.Controls.Add(this.ButtonLoadFollowerProfile);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(486, 557);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "恢复关注";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // IsSave
            // 
            this.IsSave.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.IsSave.HeaderText = "是否备份";
            this.IsSave.Name = "IsSave";
            this.IsSave.Width = 61;
            // 
            // FriendlyUID
            // 
            this.FriendlyUID.HeaderText = "用户短域名";
            this.FriendlyUID.Name = "FriendlyUID";
            // 
            // UID
            // 
            this.UID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.UID.HeaderText = "UID";
            this.UID.Name = "UID";
            this.UID.ReadOnly = true;
            // 
            // NickName
            // 
            this.NickName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NickName.HeaderText = "用户名";
            this.NickName.Name = "NickName";
            this.NickName.ReadOnly = true;
            // 
            // UserPageUri
            // 
            this.UserPageUri.HeaderText = "用户主页";
            this.UserPageUri.Name = "UserPageUri";
            // 
            // ButtonLoadFollowerProfile
            // 
            this.ButtonLoadFollowerProfile.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonLoadFollowerProfile.Location = new System.Drawing.Point(3, 3);
            this.ButtonLoadFollowerProfile.Name = "ButtonLoadFollowerProfile";
            this.ButtonLoadFollowerProfile.Size = new System.Drawing.Size(480, 23);
            this.ButtonLoadFollowerProfile.TabIndex = 0;
            this.ButtonLoadFollowerProfile.Text = "载入关注者数据";
            this.ButtonLoadFollowerProfile.UseVisualStyleBackColor = true;
            this.ButtonLoadFollowerProfile.Click += new System.EventHandler(this.ButtonLoadFollowerProfile_Click);
            // 
            // GridViewFollowerLoad
            // 
            this.GridViewFollowerLoad.AllowUserToAddRows = false;
            this.GridViewFollowerLoad.AllowUserToDeleteRows = false;
            this.GridViewFollowerLoad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewFollowerLoad.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IsRestore,
            this.LoadUID,
            this.LoadFriendlyUID,
            this.LoadUserNickName});
            this.GridViewFollowerLoad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridViewFollowerLoad.Location = new System.Drawing.Point(3, 3);
            this.GridViewFollowerLoad.Name = "GridViewFollowerLoad";
            this.GridViewFollowerLoad.Size = new System.Drawing.Size(474, 246);
            this.GridViewFollowerLoad.TabIndex = 1;
            // 
            // ButtonStartRestore
            // 
            this.ButtonStartRestore.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ButtonStartRestore.Location = new System.Drawing.Point(3, 531);
            this.ButtonStartRestore.Name = "ButtonStartRestore";
            this.ButtonStartRestore.Size = new System.Drawing.Size(480, 23);
            this.ButtonStartRestore.TabIndex = 2;
            this.ButtonStartRestore.Text = "开始恢复关注者数据";
            this.ButtonStartRestore.UseVisualStyleBackColor = true;
            this.ButtonStartRestore.Click += new System.EventHandler(this.ButtonStartRestore_Click);
            // 
            // IsRestore
            // 
            this.IsRestore.HeaderText = "是否恢复";
            this.IsRestore.Name = "IsRestore";
            this.IsRestore.Width = 70;
            // 
            // LoadUID
            // 
            this.LoadUID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.LoadUID.HeaderText = "UID";
            this.LoadUID.Name = "LoadUID";
            this.LoadUID.ReadOnly = true;
            this.LoadUID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.LoadUID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.LoadUID.Width = 32;
            // 
            // LoadFriendlyUID
            // 
            this.LoadFriendlyUID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.LoadFriendlyUID.HeaderText = "短名称";
            this.LoadFriendlyUID.Name = "LoadFriendlyUID";
            this.LoadFriendlyUID.ReadOnly = true;
            this.LoadFriendlyUID.Width = 68;
            // 
            // LoadUserNickName
            // 
            this.LoadUserNickName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.LoadUserNickName.HeaderText = "微博名";
            this.LoadUserNickName.Name = "LoadUserNickName";
            this.LoadUserNickName.ReadOnly = true;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.GridViewFollowerLoad, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.TextBoxLog, 0, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 26);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(480, 505);
            this.tableLayoutPanel5.TabIndex = 3;
            // 
            // TextBoxLog
            // 
            this.TextBoxLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBoxLog.Location = new System.Drawing.Point(3, 255);
            this.TextBoxLog.Multiline = true;
            this.TextBoxLog.Name = "TextBoxLog";
            this.TextBoxLog.Size = new System.Drawing.Size(474, 247);
            this.TextBoxLog.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 591);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewFollow)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewFollowerLoad)).EndInit();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TextBox TextBoxUri;
        private System.Windows.Forms.Button ButtonNavigate;
        private Awesomium.Windows.Forms.WebControl WebControl;
        private System.Windows.Forms.TextBox TextBoxStatus;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButtonStartBackup;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.DataGridView GridViewFollow;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn FriendlyUID;
        private System.Windows.Forms.DataGridViewTextBoxColumn UID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NickName;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserPageUri;
        private System.Windows.Forms.Button ButtonLoadFollowerProfile;
        private System.Windows.Forms.Button ButtonStartRestore;
        private System.Windows.Forms.DataGridView GridViewFollowerLoad;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsRestore;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoadUID;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoadFriendlyUID;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoadUserNickName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TextBox TextBoxLog;
    }
}