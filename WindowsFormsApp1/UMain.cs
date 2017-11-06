using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TwitchLib;
using TwitchLib.Models.Client;
using TwitchLib.Models.API;
using TwitchLib.Events.Client;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using System.Text.RegularExpressions;

namespace WindowsFormsApp1
{
    public partial class frmMain : Form
    {
        ConnectionCredentials Creds;
        TwitchClient Client;
        string DispName;
        string NameColor;
        string U_ID; // User ID
        string C_ID; // Channel ID

        public frmMain()
        {
            InitializeComponent();
        }
        // User/Channel ID Classes
        public class User
        {
            public string display_name { get; set; }
            public string _id { get; set; }
            public string name { get; set; }
            public string type { get; set; }
            public string bio { get; set; }
            public DateTime created_at { get; set; }
            public DateTime updated_at { get; set; }
            public string logo { get; set; }
        }

        public class RootObject

        {
            public int _total { get; set; }
            public List<User> users { get; set; }
        }
        // User/Channel ID Classes
        // Badge Classes
        public class GlobalMod
        {
            public string alpha { get; set; }
            public string image { get; set; }
            public string svg { get; set; }
        }

        public class Admin
        {
            public string alpha { get; set; }
            public string image { get; set; }
            public string svg { get; set; }
        }

        public class Broadcaster
        {
            public string alpha { get; set; }
            public string image { get; set; }
            public string svg { get; set; }
        }

        public class Mod
        {
            public string alpha { get; set; }
            public string image { get; set; }
            public string svg { get; set; }
        }

        public class Staff
        {
            public string alpha { get; set; }
            public string image { get; set; }
            public string svg { get; set; }
        }

        public class Turbo
        {
            public string alpha { get; set; }
            public string image { get; set; }
            public string svg { get; set; }
        }

        public class Subscriber
        {
            public string image { get; set; }
        }

        public class BadgeRoot
        {
            public GlobalMod global_mod { get; set; }
            public Admin admin { get; set; }
            public Broadcaster broadcaster { get; set; }
            public Mod mod { get; set; }
            public Staff staff { get; set; }
            public Turbo turbo { get; set; }
            public Subscriber subscriber { get; set; }
        }
        // Badge Classes end

        // Stream Classes
        public class Preview
        {
            public string small { get; set; }
            public string medium { get; set; }
            public string large { get; set; }
            public string template { get; set; }
        }

        public class Channel // cannot be used
        {
            public bool mature { get; set; }
            public string status { get; set; }
            public string broadcaster_language { get; set; }
            public string display_name { get; set; }
            public string game { get; set; }
            public string language { get; set; }
            public int _id { get; set; }
            public string name { get; set; }
            public DateTime created_at { get; set; }
            public DateTime updated_at { get; set; }
            public bool partner { get; set; }
            public string logo { get; set; }
            public string video_banner { get; set; }
            public string profile_banner { get; set; }
            public string profile_banner_background_color { get; set; }
            public string url { get; set; }
            public int views { get; set; }
            public int followers { get; set; }
            public string broadcaster_type { get; set; }
            public string description { get; set; }
        }

        public class StreamClass
        {
            public long _id { get; set; }
            public string game { get; set; }
            public string broadcast_platform { get; set; }
            public string community_id { get; set; }
            public List<string> community_ids { get; set; }
            public int viewers { get; set; }
            public int video_height { get; set; }
            public float average_fps { get; set; }
            public int delay { get; set; }
            public DateTime created_at { get; set; }
            public bool is_playlist { get; set; }
            public string stream_type { get; set; }
            public Preview preview { get; set; }
            public Channel channel { get; set; }
        }

        public class StreamRoot
        {
            public StreamClass stream { get; set; } 
        }
        // Stream Classes end
        // Channel Classes
        public class ChannelRoot
        {
            public int _id { get; set; }
            public string broadcaster_language { get; set; }
            public DateTime created_at { get; set; }
            public string display_name { get; set; }
            public int followers { get; set; }
            public string game { get; set; }
            public string language { get; set; }
            public string logo { get; set; }
            public bool mature { get; set; }
            public string name { get; set; }
            public bool partner { get; set; }
            public object profile_banner { get; set; }
            public object profile_banner_background_color { get; set; }
            public string status { get; set; }
            public DateTime updated_at { get; set; }
            public string url { get; set; }
            public object video_banner { get; set; }
            public int views { get; set; }
        }
        // Channel Classes
        
        private void ScrollToBottom() // Scrolls Webbrowser Control to the bottom
        {
            // MOST IMP : processes all windows messages queue
            Application.DoEvents();

            if (webChat.Document != null)
            {
                webChat.Document.Window.ScrollTo(0, webChat.Document.Body.ScrollRectangle.Height);
            }
        }

        private string GetID(string username)
        {
            string html = string.Empty;
            string userID;
            string url = @"https://api.twitch.tv/kraken/users?login=" + username;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Accept = "application/vnd.twitchtv.v5+json";
            request.Headers.Add("Client-ID", "0uwepl5f8n0fv7hcs282589wx76phc");
            request.Headers.Add("Authorization", edtOauth.Text);
            request.AutomaticDecompression = DecompressionMethods.GZip;

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                html = reader.ReadToEnd();
                RootObject r = JsonConvert.DeserializeObject<RootObject>(html);
                userID = r.users[0]._id;
                return userID;
            }
        }


        private void GetChannel(string ID)
        {
            string html = string.Empty;
            string url = @"https://api.twitch.tv/kraken/channels/" + ID;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Accept = "application /vnd.twitchtv.v5+json";
            request.Headers.Add("Client-ID", "0uwepl5f8n0fv7hcs282589wx76phc");
            request.AutomaticDecompression = DecompressionMethods.GZip;

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                html = reader.ReadToEnd();
                ChannelRoot r = JsonConvert.DeserializeObject<ChannelRoot>(html);
                lblStatus.Text = r.status;
                lblName.Text = r.display_name;
                lblLink.Text = r.url;
                lblLink.Enabled = true;
                pbChannelIcon.Load(r.logo);
            }
        }


        private string GetBadges(string ID,string Raw)
        {
            string html = string.Empty;
            string BadgeURL="";
            string url = @"https://api.twitch.tv/kraken/chat/"+ID+"/badges";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Accept = "application/vnd.twitchtv.v5+json";
            request.Headers.Add("Client-ID", "0uwepl5f8n0fv7hcs282589wx76phc");
            request.AutomaticDecompression = DecompressionMethods.GZip;

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                html = reader.ReadToEnd();
                BadgeRoot r = JsonConvert.DeserializeObject<BadgeRoot>(html);
                switch (Raw) {
                    case "admin": { BadgeURL = r.admin.image; break; }
                    case "broadcaster": { BadgeURL = r.broadcaster.image; break; }
                    case "global_mod": { BadgeURL = r.global_mod.image; break; }
                    case "mod": { BadgeURL = r.mod.image; break; }
                    case "staff": { BadgeURL = r.staff.image; break; }
                    case "subscriber": { BadgeURL = r.subscriber.image; break; }
                    case "turbo": { BadgeURL = r.turbo.image; break; }
                }
                return BadgeURL;
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            Creds = new ConnectionCredentials(edtUser.Text, edtOauth.Text);
            Client = new TwitchClient(Creds, edtChannel.Text, '!', '!', true);

            Client.OnNewSubscriber += OnNewSubscriber;
            Client.OnMessageReceived += OnMessageReceived;
            Client.OnMessageSent += OnMessageSent;
            Client.OnUserBanned += OnUserBanned;
            Client.OnUserTimedout += OnUserTimedout;
            Client.OnLog += OnLog;
            Client.OnIncorrectLogin += OnIncorrectLogin;
            Client.OnNowHosting += OnNowHosting;
            Client.OnHostingStarted += OnHostingStarted;
            Client.OnHostingStopped += OnHostingStopped;
            Client.Connect();
            Client.WillReplaceEmotes = true;
            btnConnect.Enabled = false;
            btnDisconnect.Enabled = true;
            edtMessage.Enabled = true;
            btnSend.Enabled = true;
            lbEmotes.Enabled = true;
            btnSendEmotes.Enabled = true;
            speCount.Enabled = true;
            btnPower.Enabled = true;
            btnPowerJ.Enabled = true;
            btnPowerKursive.Enabled = true;
            btnSend.Enabled = true;
            edtMessage.Enabled = true;

            edtUser.Enabled = false;
            edtChannel.Enabled = false;
            edtOauth.Enabled = false;

            //Channel ID
            C_ID = GetID(edtChannel.Text);
            U_ID = GetID(edtUser.Text);
            tmStream.Enabled = true;
            GetChannel(C_ID);

        }

        private void lblOauthLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://twitchapps.com/tmi/");
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            Client.Disconnect();
            btnConnect.Enabled = true;
            btnDisconnect.Enabled = false;
            edtMessage.Enabled = false;
            btnSend.Enabled = false;
            webChat.Navigate("about:blank");
            tmStream.Enabled = false;
        
            lbEmotes.Enabled = false;
            btnSendEmotes.Enabled = false;
            speCount.Enabled = false;
            btnPower.Enabled = false;
            btnPowerJ.Enabled = false;
            btnPowerKursive.Enabled = false;
            btnSend.Enabled = false;
            edtMessage.Enabled = false;

            edtUser.Enabled = true;
            edtChannel.Enabled = true;
            edtOauth.Enabled = true;

            pbChannelIcon.Image = null;
            lblStatus.Text = "-";
            lblViewers.Text = "-";
            lblGame.Text = "-";
            lblLink.Text = "-";
            lblName.Text = "-";
            RichLog.Clear();
            lblLink.Enabled = false;
        }

        private void OnMessageReceived(object sender, OnMessageReceivedArgs e)
        {
            string states = "";
            string ChatM = "";
            string content = "";
            string Raw = e.ChatMessage.RawIrcMessage;
            if (Raw.Contains("subscriber/"))
            {
                states += "<img src=\"" + GetBadges(C_ID, "subscriber") + "\"> ";
            }
            if (Raw.Contains("admin/"))
            {
                states += "<img src=\"" + GetBadges(C_ID, "admin") + "\"> ";
            }
            if (Raw.Contains("bits/"))
            {
                states += "[B] ";
            }
            if (Raw.Contains("global_mod/"))
            {
                states += "<img src=\"" + GetBadges(C_ID, "global_mod") + "\"> ";
            }
            if (Raw.Contains("staff/"))
            {
                states += "<img src=\"" + GetBadges(C_ID, "staff") + "\"> ";
            }
            if (Raw.Contains("moderator/"))
            {
                states += "<img src=\"" + GetBadges(C_ID, "mod") + "\"> ";
            }
            if (Raw.Contains("broadcaster/"))
            {
                states += "<img src=\"" + GetBadges(C_ID, "broadcaster") + "\"> ";
            }
            if (Raw.Contains("premium/"))
            {
                //states += "[P] ";
                states += "<img src=\"https://static-cdn.jtvnw.net/badges/v1/a1dd5073-19c3-4911-8cb4-c464a7bc1510/1\"> ";
            }
            if (Raw.Contains("turbo/"))
            {
                states += "<img src=\""+GetBadges(C_ID, "turbo")+"\"> ";
            }
            if (Raw.Contains("NOTICE"))
            {
                string Notice = Raw.Substring(Raw.LastIndexOf(':') + 1);
                if (webChat.InvokeRequired)
                {
                    Action act = () => this.webChat.Document.Body.InnerHtml += Notice;
                    webChat.Invoke(act);
                    act = () => ScrollToBottom();
                    webChat.Invoke(act);
                }
            }
            DispName = states + e.ChatMessage.DisplayName;
            ChatM = e.ChatMessage.Message;
            ChatM = Regex.Replace(ChatM, @"^(http|https|ftp)\://[a-zA-Z0-9\-\.]+\.[a-zA-Z]{2,3}(:[a-zA-Z0-9]*)?/?([a-zA-Z0-9\-\._\?\,\'/\\\+&amp;%\$#\=~])*$","<a href=\"$1\">$1</a>");
            for (int i = 0; i < e.ChatMessage.EmoteSet.Emotes.Count; i++)
            {
                ChatM = ChatM.Replace(e.ChatMessage.EmoteSet.Emotes[i].Name, "<img src=\"" + e.ChatMessage.EmoteSet.Emotes[i].ImageUrl + "\">");
            }
            NameColor = e.ChatMessage.ColorHex;
            if (e.ChatMessage.IsMe)
            {
                content = "<div><span style=\"color:" + NameColor + "; font-family:Arial,Helvetica,sans-serif; font-size:10pt;\"><strong>" + DispName.ToString() + "</strong> " + ChatM + "</span></div>";
            }
            else
            {
                content = "<div><span style=\"color:" + NameColor + "; font-family:Arial,Helvetica,sans-serif; font-size:10pt;\"><strong>" + DispName.ToString() + ": </strong></span><span style=\"font-family:Arial,Helvetica,sans-serif; font-size:10pt;\">" + ChatM + "</span></div>";
            }
            if (webChat.InvokeRequired)
            {
                Action act = () => this.webChat.Document.Body.InnerHtml += content;
                webChat.Invoke(act);
                act = () => ScrollToBottom();
                webChat.Invoke(act);
            }
            else
            {
                this.webChat.DocumentText += content;
            }
        }


        private void OnLog(object sender, OnLogArgs e)
        {
              if (RichLog.InvokeRequired)
              { 
                   if (!(e.Data.Contains("PRIVMSG")) && !(e.Data.Contains("Unaccounted for:"))) //filter PRIVMSG
                   {
                    Action act = () => RichLog.AppendText(e.DateTime + " " + e.BotUsername + " " + e.Data + "\r\n");
                    RichLog.Invoke(act);
                   }
            }
            if (e.Data.Contains("NOTICE") && !(e.Data.Contains("Unaccounted for:")))
            {
                string Notice = "<div><span style=\"color:#A4A0A0; font-family:Arial,Helvetica,sans-serif; font-size:10pt;\">"+e.Data.Substring(e.Data.LastIndexOf(':') + 1) + "</span></div>";
                if (webChat.InvokeRequired)
                {
                    Action act = () => this.webChat.Document.Body.InnerHtml += Notice;
                    webChat.Invoke(act);
                    act = () => ScrollToBottom();
                    webChat.Invoke(act);
                }
            }
        }

        private void OnIncorrectLogin(object sender, OnIncorrectLoginArgs e)
        {
            const string message ="Username or Oauth token wrong";
            const string caption = "Login Error";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.OK,MessageBoxIcon.Error);

            // If the no button was pressed ...
            if (result == DialogResult.OK)
            {
                btnDisconnect_Click(sender, e);
            }
        }

        private void OnNewSubscriber(object sender, OnNewSubscriberArgs e)
        {
            string content = "";
            if (e.Subscriber.IsTwitchPrime)
                content = "<div><span style=\"color:#A4A0A0; font-family:Arial,Helvetica,sans-serif; font-size:10pt;\">" + e.Subscriber.DisplayName + " just subscrived to " + e.Channel + " with twitch Prime. " + e.Subscriber.ResubMessage + "</span></div>";
            else
                content = "<div><span style=\"color:#A4A0A0; font-family:Arial,Helvetica,sans-serif; font-size:10pt;\">" + e.Subscriber.DisplayName + " just subscrived to " + e.Channel + ". " + e.Subscriber.ResubMessage + "</span></div>";
            if (webChat.InvokeRequired)
            {
                Action act = () => this.webChat.Document.Body.InnerHtml += content;
                webChat.Invoke(act);
                act = () => ScrollToBottom();
                webChat.Invoke(act);
            }
        }

        private void OnReSubscriber(object sender, OnReSubscriberArgs e)
        {
            string content = "";
            if (e.ReSubscriber.IsTwitchPrime)
                content = "<div><span style=\"color:#A4A0A0; font-family:Arial,Helvetica,sans-serif; font-size:10pt;\">" + e.ReSubscriber.DisplayName + " just resubscribed to " + e.ReSubscriber.Channel + " for " + e.ReSubscriber.Months + " with Twitch Prime. " + e.ReSubscriber.ResubMessage + "</span></div>";
            else
                content = "<div><span style=\"color:#A4A0A0; font-family:Arial,Helvetica,sans-serif; font-size:10pt;\">" + e.ReSubscriber.DisplayName + " just resubscribed to " + e.ReSubscriber.Channel + " for " + e.ReSubscriber.Months + ". " + e.ReSubscriber.ResubMessage + "</span></div>";
            if (webChat.InvokeRequired)
            {
                Action act = () => this.webChat.Document.Body.InnerHtml += content;
                webChat.Invoke(act);
                act = () => ScrollToBottom();
                webChat.Invoke(act);
            }
        }

        private void OnMessageSent(object sender, OnMessageSentArgs e)
        {
            string states = "";
            string ChatM = "";
            string content = "";
            DispName = states + e.SentMessage.DisplayName;
            ChatM = e.SentMessage.Message;
            NameColor = e.SentMessage.ColorHex;
            if (e.SentMessage.IsSubscriber)
            {
                states += "<img src=\"" + GetBadges(C_ID, "subscriber") + "\"> ";
            }
             if (e.SentMessage.UserType.ToString() == "Admin")
             {
                 states += "<img src=\"" + GetBadges(C_ID, "admin") + "\"> ";
             }
            if (e.SentMessage.IsModerator)
            {
                states += "<img src=\"" + GetBadges(C_ID, "mod") + "\"> ";
            }
            if (e.SentMessage.UserType.ToString() == "Broadcaster")
            {
                states += "<img src=\"" + GetBadges(C_ID, "broadcaster") + "\"> ";
            }
            content = "<div><span style=\"color:" + NameColor + "; font-family:Arial,Helvetica,sans-serif; font-size:10pt;\"><strong>" + DispName.ToString() + ": </strong></span><span style=\"font-family:Arial,Helvetica,sans-serif; font-size:10pt;\">" + ChatM + "</span></div>";
            if (webChat.InvokeRequired)
            {
                Action act = () => this.webChat.Document.Body.InnerHtml += content;
                webChat.Invoke(act);
                act = () => ScrollToBottom();
                webChat.Invoke(act);
            }
            else
            {
                this.webChat.DocumentText += content;
            }
        }

        private void OnUserBanned(object sender, OnUserBannedArgs e)
        {
            string content = "";
            content = "<div><span style=\"color:#A4A0A0; font-family:Arial,Helvetica,sans-serif; font-size:10pt;\">" + e.Username + " has been banned from " + e.Channel + ". Reason: " + e.BanReason + "</span></div>";
            if (webChat.InvokeRequired)
            {
                Action act = () => this.webChat.Document.Body.InnerHtml += content;
                webChat.Invoke(act);
                act = () => ScrollToBottom();
                webChat.Invoke(act);
            }
        }

        private void OnUserTimedout(object sender, OnUserTimedoutArgs e)
        {
            string content = "";
            content = "<div><span style=\"color:#A4A0A0; font-family:Arial,Helvetica,sans-serif; font-size:10pt;\">" + e.Username + " has been timed out from " + e.Channel + "for " + e.TimeoutDuration + " seconds. Reason: " + e.TimeoutReason + "</span></div>";
            if (webChat.InvokeRequired)
            {
                Action act = () => this.webChat.Document.Body.InnerHtml += content;
                webChat.Invoke(act);
                act = () => ScrollToBottom();
                webChat.Invoke(act);
            }
        }

        private void OnNowHosting(object sender, OnNowHostingArgs e)
        {
            string content = "";
            content = "<div><span style=\"color:#A4A0A0; font-family:Arial,Helvetica,sans-serif; font-size:10pt;\">" + e.Channel + " is now hosting " + e.HostedChannel + "</span></div>";
            if (webChat.InvokeRequired)
            {
                Action act = () => this.webChat.Document.Body.InnerHtml += content;
                webChat.Invoke(act);
                act = () => ScrollToBottom();
                webChat.Invoke(act);
            }
        }

        private void OnHostingStarted(object sender, OnHostingStartedArgs e)
        {
            string content = "";
            content = "<div><span style=\"color:#A4A0A0; font-family:Arial,Helvetica,sans-serif; font-size:10pt;\">" + e.HostingChannel + " is now hosting " + e.TargetChannel + " for "+e.Viewers+" viewers.</span></div>";
            if (webChat.InvokeRequired)
            {
                Action act = () => this.webChat.Document.Body.InnerHtml += content;
                webChat.Invoke(act);
                act = () => ScrollToBottom();
                webChat.Invoke(act);
            }
        }

        private void OnHostingStopped(object sender, OnHostingStoppedArgs e)
        {
            string content = "";
            content = "<div><span style=\"color:#A4A0A0; font-family:Arial,Helvetica,sans-serif; font-size:10pt;\">Stopped hosting " + e.HostingChannel + " for " + e.Viewers + " viewers.</span></div>";
            if (webChat.InvokeRequired)
            {
                Action act = () => this.webChat.Document.Body.InnerHtml += content;
                webChat.Invoke(act);
                act = () => ScrollToBottom();
                webChat.Invoke(act);
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            Client.SendMessage(edtMessage.Text);
        }

        private void btnSend_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                Client.SendMessage(edtMessage.Text);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            webChat.Navigate("about:blank");
            string[] lines = System.IO.File.ReadAllLines("emotes.txt");
            lbEmotes.Items.AddRange(lines);
        }

        private void btnPower_Click(object sender, EventArgs e)
        {
            edtMessage.Text= "O-oooooooooo AAAAE-A-A-I-A-U-JO-oooooooooooo AAE-O-A-A-U-U-A-E-eee-ee-eee AAAAE-A-E-I-E-A-JO-ooo-oo-oo-oo EEEEO-A-AAA-AAAA";
            btnSend_Click(sender, e);
        }

        private void btnPowerJ_Click(object sender, EventArgs e)
        {
            edtMessage.Text = "おーおおおおおおおおおお ああああえーあーあーいーあーうー じょーおおおおおおおおおおおお ああえーおーあーあーうーうーあー えーえええーええーえええ ああああえーあーえーいーえーあー じょーおおおーおおーおおーおお ええええおーあーあああーああああ";
            btnSend_Click(sender, e);
        }

        private void btnPowerKursive_Click(object sender, EventArgs e)
        {
            edtMessage.Text = "𝓞-𝓸𝓸𝓸𝓸𝓸𝓸𝓸𝓸𝓸𝓸 𝓐𝓐𝓐𝓐𝓔-𝓐-𝓐-𝓘-𝓐-𝓤- 𝓙𝓞-𝓸𝓸𝓸𝓸𝓸𝓸𝓸𝓸𝓸𝓸𝓸𝓸 𝓐𝓐𝓔-𝓞-𝓐-𝓐-𝓤-𝓤-𝓐- 𝓔-𝒆𝒆𝒆-𝒆𝒆-𝒆𝒆𝒆 𝓐𝓐𝓐𝓐𝓔-𝓐-𝓔-𝓘-𝓔-𝓐-𝓙𝓞-𝓸𝓸𝓸-𝓸𝓸-𝓸𝓸-𝓸𝓸 𝓔𝓔𝓔𝓔𝓞-𝓐-𝓐𝓐𝓐-𝓐𝓐𝓐𝓐";
            btnSend_Click(sender, e);
        }

        private void btnSendEmotes_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= speCount.Value; i++)
            {
                edtMessage.Text = edtMessage.Text + lbEmotes.Items[lbEmotes.SelectedIndex] + ' ';
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string html = string.Empty;
            string url = @"https://api.twitch.tv/kraken/streams/"+C_ID;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Accept = "application /vnd.twitchtv.v5+json";
            request.Headers.Add("Client-ID", "0uwepl5f8n0fv7hcs282589wx76phc");
            request.AutomaticDecompression = DecompressionMethods.GZip;

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                html = reader.ReadToEnd();
                StreamRoot r = JsonConvert.DeserializeObject<StreamRoot>(html);
                if (r.stream != null)
                {
                    lblGame.Text = r.stream.game;
                    lblViewers.Text = r.stream.viewers.ToString(); //viewers > int
                }
                else
                {
                    lblGame.Text = "-";
                    lblViewers.Text = "-"; //viewers > int
                }
            }
        }

        private void lblLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (lblLink.Text != "-")
            {
                System.Diagnostics.Process.Start(lblLink.Text);
            }
        }
    }
}
