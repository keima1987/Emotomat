namespace WindowsFormsApp1
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.edtMessage = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.webChat = new System.Windows.Forms.WebBrowser();
            this.gbLogin = new System.Windows.Forms.GroupBox();
            this.lblOauthLink = new System.Windows.Forms.LinkLabel();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.lblChannel = new System.Windows.Forms.Label();
            this.edtChannel = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.lblOauth = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.edtOauth = new System.Windows.Forms.TextBox();
            this.edtUser = new System.Windows.Forms.TextBox();
            this.gbEmotes = new System.Windows.Forms.GroupBox();
            this.lbEmotes = new System.Windows.Forms.ListBox();
            this.btnSendEmotes = new System.Windows.Forms.Button();
            this.speCount = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnPowerKursive = new System.Windows.Forms.Button();
            this.btnPowerJ = new System.Windows.Forms.Button();
            this.btnPower = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblLink = new System.Windows.Forms.LinkLabel();
            this.lblName = new System.Windows.Forms.Label();
            this.lblViewers = new System.Windows.Forms.Label();
            this.lblGame = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.pbChannelIcon = new System.Windows.Forms.PictureBox();
            this.tmStream = new System.Windows.Forms.Timer(this.components);
            this.RichLog = new System.Windows.Forms.RichTextBox();
            this.gbLogin.SuspendLayout();
            this.gbEmotes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.speCount)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbChannelIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // edtMessage
            // 
            this.edtMessage.Enabled = false;
            this.edtMessage.Location = new System.Drawing.Point(12, 622);
            this.edtMessage.Name = "edtMessage";
            this.edtMessage.Size = new System.Drawing.Size(556, 22);
            this.edtMessage.TabIndex = 0;
            // 
            // btnSend
            // 
            this.btnSend.Enabled = false;
            this.btnSend.Location = new System.Drawing.Point(574, 622);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(99, 23);
            this.btnSend.TabIndex = 1;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            this.btnSend.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnSend_KeyPress);
            // 
            // webChat
            // 
            this.webChat.AllowWebBrowserDrop = false;
            this.webChat.Location = new System.Drawing.Point(679, 10);
            this.webChat.MinimumSize = new System.Drawing.Size(20, 20);
            this.webChat.Name = "webChat";
            this.webChat.ScriptErrorsSuppressed = true;
            this.webChat.Size = new System.Drawing.Size(434, 634);
            this.webChat.TabIndex = 14;
            // 
            // gbLogin
            // 
            this.gbLogin.Controls.Add(this.lblOauthLink);
            this.gbLogin.Controls.Add(this.btnDisconnect);
            this.gbLogin.Controls.Add(this.lblChannel);
            this.gbLogin.Controls.Add(this.edtChannel);
            this.gbLogin.Controls.Add(this.btnConnect);
            this.gbLogin.Controls.Add(this.lblOauth);
            this.gbLogin.Controls.Add(this.lblUsername);
            this.gbLogin.Controls.Add(this.edtOauth);
            this.gbLogin.Controls.Add(this.edtUser);
            this.gbLogin.Location = new System.Drawing.Point(12, 11);
            this.gbLogin.Name = "gbLogin";
            this.gbLogin.Size = new System.Drawing.Size(322, 210);
            this.gbLogin.TabIndex = 15;
            this.gbLogin.TabStop = false;
            this.gbLogin.Text = "Login Information";
            // 
            // lblOauthLink
            // 
            this.lblOauthLink.AutoSize = true;
            this.lblOauthLink.Location = new System.Drawing.Point(7, 125);
            this.lblOauthLink.Name = "lblOauthLink";
            this.lblOauthLink.Size = new System.Drawing.Size(73, 13);
            this.lblOauthLink.TabIndex = 20;
            this.lblOauthLink.TabStop = true;
            this.lblOauthLink.Text = "Oauth token";
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Enabled = false;
            this.btnDisconnect.Location = new System.Drawing.Point(6, 180);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(310, 23);
            this.btnDisconnect.TabIndex = 5;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // lblChannel
            // 
            this.lblChannel.AutoSize = true;
            this.lblChannel.Location = new System.Drawing.Point(7, 102);
            this.lblChannel.Name = "lblChannel";
            this.lblChannel.Size = new System.Drawing.Size(53, 13);
            this.lblChannel.TabIndex = 18;
            this.lblChannel.Text = "Channel:";
            // 
            // edtChannel
            // 
            this.edtChannel.Location = new System.Drawing.Point(89, 99);
            this.edtChannel.Name = "edtChannel";
            this.edtChannel.Size = new System.Drawing.Size(227, 22);
            this.edtChannel.TabIndex = 3;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(6, 151);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(310, 23);
            this.btnConnect.TabIndex = 4;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // lblOauth
            // 
            this.lblOauth.AutoSize = true;
            this.lblOauth.Location = new System.Drawing.Point(7, 64);
            this.lblOauth.Name = "lblOauth";
            this.lblOauth.Size = new System.Drawing.Size(77, 13);
            this.lblOauth.TabIndex = 15;
            this.lblOauth.Text = "OAuth token:";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(7, 26);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(61, 13);
            this.lblUsername.TabIndex = 14;
            this.lblUsername.Text = "Username:";
            // 
            // edtOauth
            // 
            this.edtOauth.Location = new System.Drawing.Point(89, 60);
            this.edtOauth.Name = "edtOauth";
            this.edtOauth.PasswordChar = '*';
            this.edtOauth.Size = new System.Drawing.Size(227, 22);
            this.edtOauth.TabIndex = 2;
            // 
            // edtUser
            // 
            this.edtUser.Location = new System.Drawing.Point(89, 21);
            this.edtUser.Name = "edtUser";
            this.edtUser.Size = new System.Drawing.Size(227, 22);
            this.edtUser.TabIndex = 1;
            // 
            // gbEmotes
            // 
            this.gbEmotes.Controls.Add(this.lbEmotes);
            this.gbEmotes.Controls.Add(this.btnSendEmotes);
            this.gbEmotes.Controls.Add(this.speCount);
            this.gbEmotes.Location = new System.Drawing.Point(12, 220);
            this.gbEmotes.Name = "gbEmotes";
            this.gbEmotes.Size = new System.Drawing.Size(322, 229);
            this.gbEmotes.TabIndex = 16;
            this.gbEmotes.TabStop = false;
            this.gbEmotes.Text = "Emote Corner";
            // 
            // lbEmotes
            // 
            this.lbEmotes.Enabled = false;
            this.lbEmotes.FormattingEnabled = true;
            this.lbEmotes.Location = new System.Drawing.Point(6, 21);
            this.lbEmotes.Name = "lbEmotes";
            this.lbEmotes.Size = new System.Drawing.Size(184, 199);
            this.lbEmotes.TabIndex = 0;
            // 
            // btnSendEmotes
            // 
            this.btnSendEmotes.Enabled = false;
            this.btnSendEmotes.Location = new System.Drawing.Point(196, 49);
            this.btnSendEmotes.Name = "btnSendEmotes";
            this.btnSendEmotes.Size = new System.Drawing.Size(120, 171);
            this.btnSendEmotes.TabIndex = 2;
            this.btnSendEmotes.Text = "Insert Emotes";
            this.btnSendEmotes.UseVisualStyleBackColor = true;
            this.btnSendEmotes.Click += new System.EventHandler(this.btnSendEmotes_Click);
            // 
            // speCount
            // 
            this.speCount.Enabled = false;
            this.speCount.Location = new System.Drawing.Point(196, 21);
            this.speCount.Name = "speCount";
            this.speCount.Size = new System.Drawing.Size(120, 22);
            this.speCount.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnPowerKursive);
            this.groupBox2.Controls.Add(this.btnPowerJ);
            this.groupBox2.Controls.Add(this.btnPower);
            this.groupBox2.Location = new System.Drawing.Point(342, 220);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(325, 229);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sonic Brain Power";
            // 
            // btnPowerKursive
            // 
            this.btnPowerKursive.Enabled = false;
            this.btnPowerKursive.Location = new System.Drawing.Point(6, 165);
            this.btnPowerKursive.Name = "btnPowerKursive";
            this.btnPowerKursive.Size = new System.Drawing.Size(312, 55);
            this.btnPowerKursive.TabIndex = 2;
            this.btnPowerKursive.Text = " Send Power Kursive";
            this.btnPowerKursive.UseVisualStyleBackColor = true;
            this.btnPowerKursive.Click += new System.EventHandler(this.btnPowerKursive_Click);
            // 
            // btnPowerJ
            // 
            this.btnPowerJ.Enabled = false;
            this.btnPowerJ.Location = new System.Drawing.Point(6, 93);
            this.btnPowerJ.Name = "btnPowerJ";
            this.btnPowerJ.Size = new System.Drawing.Size(312, 55);
            this.btnPowerJ.TabIndex = 1;
            this.btnPowerJ.Text = " Send Power! Japanese";
            this.btnPowerJ.UseVisualStyleBackColor = true;
            this.btnPowerJ.Click += new System.EventHandler(this.btnPowerJ_Click);
            // 
            // btnPower
            // 
            this.btnPower.Enabled = false;
            this.btnPower.Location = new System.Drawing.Point(6, 21);
            this.btnPower.Name = "btnPower";
            this.btnPower.Size = new System.Drawing.Size(312, 55);
            this.btnPower.TabIndex = 0;
            this.btnPower.Text = " Send Power!";
            this.btnPower.UseVisualStyleBackColor = true;
            this.btnPower.Click += new System.EventHandler(this.btnPower_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblLink);
            this.groupBox3.Controls.Add(this.lblName);
            this.groupBox3.Controls.Add(this.lblViewers);
            this.groupBox3.Controls.Add(this.lblGame);
            this.groupBox3.Controls.Add(this.lblStatus);
            this.groupBox3.Controls.Add(this.pbChannelIcon);
            this.groupBox3.Location = new System.Drawing.Point(342, 11);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(324, 210);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Stream Information";
            // 
            // lblLink
            // 
            this.lblLink.AutoSize = true;
            this.lblLink.Enabled = false;
            this.lblLink.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLink.Location = new System.Drawing.Point(116, 184);
            this.lblLink.Name = "lblLink";
            this.lblLink.Size = new System.Drawing.Size(15, 19);
            this.lblLink.TabIndex = 10;
            this.lblLink.TabStop = true;
            this.lblLink.Text = "-";
            this.lblLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblLink_LinkClicked);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(116, 102);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(15, 19);
            this.lblName.TabIndex = 9;
            this.lblName.Text = "-";
            // 
            // lblViewers
            // 
            this.lblViewers.AutoSize = true;
            this.lblViewers.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViewers.ForeColor = System.Drawing.Color.Crimson;
            this.lblViewers.Location = new System.Drawing.Point(6, 78);
            this.lblViewers.Name = "lblViewers";
            this.lblViewers.Size = new System.Drawing.Size(15, 19);
            this.lblViewers.TabIndex = 8;
            this.lblViewers.Text = "-";
            // 
            // lblGame
            // 
            this.lblGame.AutoSize = true;
            this.lblGame.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGame.Location = new System.Drawing.Point(6, 48);
            this.lblGame.Name = "lblGame";
            this.lblGame.Size = new System.Drawing.Size(15, 19);
            this.lblGame.TabIndex = 7;
            this.lblGame.Text = "-";
            // 
            // lblStatus
            // 
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(6, 20);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(312, 19);
            this.lblStatus.TabIndex = 6;
            this.lblStatus.Text = "-";
            // 
            // pbChannelIcon
            // 
            this.pbChannelIcon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbChannelIcon.Location = new System.Drawing.Point(10, 102);
            this.pbChannelIcon.Name = "pbChannelIcon";
            this.pbChannelIcon.Size = new System.Drawing.Size(100, 100);
            this.pbChannelIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbChannelIcon.TabIndex = 4;
            this.pbChannelIcon.TabStop = false;
            // 
            // tmStream
            // 
            this.tmStream.Interval = 10000;
            this.tmStream.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // RichLog
            // 
            this.RichLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RichLog.Location = new System.Drawing.Point(12, 455);
            this.RichLog.Name = "RichLog";
            this.RichLog.Size = new System.Drawing.Size(661, 161);
            this.RichLog.TabIndex = 2;
            this.RichLog.Text = "";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 656);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbEmotes);
            this.Controls.Add(this.gbLogin);
            this.Controls.Add(this.webChat);
            this.Controls.Add(this.RichLog);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.edtMessage);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "Keima\'s Emot-o-mat .NET";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbLogin.ResumeLayout(false);
            this.gbLogin.PerformLayout();
            this.gbEmotes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.speCount)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbChannelIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox edtMessage;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.WebBrowser webChat;
        private System.Windows.Forms.GroupBox gbLogin;
        private System.Windows.Forms.LinkLabel lblOauthLink;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Label lblChannel;
        private System.Windows.Forms.TextBox edtChannel;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label lblOauth;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox edtOauth;
        private System.Windows.Forms.TextBox edtUser;
        private System.Windows.Forms.GroupBox gbEmotes;
        private System.Windows.Forms.ListBox lbEmotes;
        private System.Windows.Forms.Button btnSendEmotes;
        private System.Windows.Forms.NumericUpDown speCount;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnPowerKursive;
        private System.Windows.Forms.Button btnPowerJ;
        private System.Windows.Forms.Button btnPower;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Timer tmStream;
        private System.Windows.Forms.PictureBox pbChannelIcon;
        private System.Windows.Forms.LinkLabel lblLink;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblViewers;
        private System.Windows.Forms.Label lblGame;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.RichTextBox RichLog;
    }
}

