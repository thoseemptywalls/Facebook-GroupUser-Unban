using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace fbook
{
    public partial class Process : Form
    {
        public Process()
        {
            InitializeComponent();

        }

        frmMain frm = new frmMain();

        public async void GetUserID(string link)
        {
            this.Show();
            await Task.Delay(5000);          
            try
            {
                foreach (HtmlElement he in ProcessBrowser.Document.All.GetElementsByName("fburl"))
                {
                    he.SetAttribute("value", link);
                }
                var elements = ProcessBrowser.Document.GetElementsByTagName("button");
                foreach (HtmlElement element in elements)
                {
                    if (element.InnerHtml.Contains("Find Facebook"))
                    {
                        element.InvokeMember("Click");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("The operation failed. Go to LOG for more information.", "Exception");
                LogErrors.Excep(ex.GetType().FullName, ex.Message);
                this.Close();
            }
        }


        public async void UnbanUsers(string groupID, string UserID)
        {
            this.Show();
            try
            {
                await Task.Delay(5000);
                HtmlElementCollection col = ProcessBrowser.Document.GetElementsByTagName("a");
                bool first = true;
                foreach (HtmlElement el in col)
                {

                    if (el.GetAttribute("href").Contains("remove_block"))
                    {
                        if (first)
                        {
                            el.SetAttribute("href", "/ajax/groups/admins_get.php/?group_id=" + groupID + "&user_id=" + UserID + "&action=remove_block&source=profilebrowser_blocked");
                            el.InvokeMember("Click");
                            await Task.Delay(2000);
                            foreach (HtmlElement he in ProcessBrowser.Document.All.GetElementsByName("remove_block"))
                            {
                                await Task.Delay(2000);
                                he.InvokeMember("Click");
                                first = false;
                                await Task.Delay(4000);
                            }
                            first = false;
                            this.Close();
                        }

                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("The user is already unbanned, or you dont have permission to perform this function.", ex.GetType().Name);
                LogErrors.Excep(ex.GetType().FullName, ex.Message);
            }
        }



        private void Process_Load(object sender, EventArgs e)
        {
            bTimer.Interval = 20000;
            bTimer.Tick += new EventHandler(timer1_Tick);
        }

        public async void ProcessBrowser_DocumentCompleted_1(object sender, WebBrowserDocumentCompletedEventArgs e)
        {     
            var url = ProcessBrowser.Url.AbsoluteUri;
            if (this.ProcessBrowser.ReadyState == WebBrowserReadyState.Complete)
            { 
                if (url.Contains("/success/"))
                {
                    var resultString = Regex.Match(url, @"\d+").Value;
                    frm.GetUserID(resultString);
                    await Task.Delay(2000);
                    Close();
                }
                bTimer.Start();
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
          this.Close();
        }
    }
}
    