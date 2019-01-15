using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace fbook
{
    public partial class Login : MaterialForm
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            string OAuthURL = @"https://www.facebook.com/dialog/oauth?client_id=" + AppSettings.Default.AppID + "&redirect_uri=https://www.facebook.com/connect/login_success.html&response_type=token&scope=" + AppSettings.Default.Scope;
            WebFacebook.Navigate(OAuthURL);
        }

        private void WebFacebook_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            string access_token;
            if (WebFacebook.Url.AbsoluteUri.Contains("access_token"))
            {
                string url1 = WebFacebook.Url.AbsoluteUri;
                string url2 = url1.Substring(url1.IndexOf("access_token") + 13);
                access_token = url2.Substring(0, url2.IndexOf("&"));
                AppSettings.Default.AccessToken = access_token;
        
                Close();
                MainLogin.IsLogin = true;
                MainLogin.IsBackFromLogin = true;
            }
        }
    }
}
