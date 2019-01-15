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
    public partial class frmMain : MaterialForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        public static string behavior;
        private void frmMain_Load(object sender, EventArgs e)
        {
            aTimer.Interval = 13000;
            aTimer.Tick += new EventHandler(aTimer_Tick);
            if (!(FBClass.GetUserName(AppSettings.Default.AccessToken) == ""))
            {
                WelcomeLabel.Text = "Seja muito bem-vindo(a), " + (FBClass.GetUserName(AppSettings.Default.AccessToken) + ". ;-)");
                frmMain frm = new frmMain();
                frm.Text = (FBClass.GetUserName(AppSettings.Default.AccessToken));
            }         
            else
            {
                WelcomeLabel.Text = "Falha ao conectar com usuário. ;-(";
            }
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainLogin.IsOpen = false;
        }

        public void GetUserID(string havior)
        {
            behavior = havior;
        }


        private void BtnGetUserID_Click(object sender, EventArgs e)
        {         
            if (UserLink.Text == "https://www.facebook.com/" || UserLink.Text == "http://www.facebook.com/")
            {
                MessageBox.Show("Please provide someone's profile link, not the main Facebook page.", "Oops");
            }
            else if (!UserLink.Text.StartsWith("https://www.facebook.com/"))
            {
                MessageBox.Show("Please provide a valid link.\nYour link should start with ''https://www.facebook.com/''.", "Oops");
            }
            else
            {
                Process prcss = new Process();
                BtnGetUserID.Enabled = false;
                prcss.ProcessBrowser.Navigate("https://findmyfbid.in/");
                aTimer.Start();
                prcss.GetUserID(UserLink.Text);
            }

        }

        private void aTimer_Tick(object sender, EventArgs e)
        {
            if (IdUserInput.Text == "")
            {
                IdUserInput.Text = "0000000000000000";
            }
            else
            {
                IdUserInput.Text = behavior;
            }
            BtnGetUserID.Enabled = true;
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(IdUserInput.Text);

        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            Process prcss = new Process();
            if (userIDtoUnban.Text == "")
            {
                MessageBox.Show("You must indicate some user ID first.\n\n" +
                    "You can get this user ID through someone's profile link, and then use it in the above function.", "Oops");
            }
            else if (groupID.Text == "")
            {
                MessageBox.Show("You must select a group first.", "Oops");
            }
            else
            {
                prcss.ProcessBrowser.Navigate("https://www.facebook.com/groups/" + groupID.Text + "/blocked/");
                prcss.UnbanUsers(groupID.Text, userIDtoUnban.Text);
            }


        }

        private void groupID_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void userIDtoUnban_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
