using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace fbook
{
    public partial class MainLogin : MaterialForm
    {
        public MainLogin()
        {
            InitializeComponent();
            NetworkAvailabilityChangedEventHandler myHandler = new NetworkAvailabilityChangedEventHandler(AvailabilityChanged);
            NetworkChange.NetworkAvailabilityChanged += myHandler;

            //MATERIAL SKINS
            // Create a material theme manager and add the form to manage (this)
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            // Configure color schema
            materialSkinManager.ColorScheme = new ColorScheme(
            Primary.Blue400, Primary.Blue500,
            Primary.Blue500, Accent.Blue200,
            TextShade.WHITE);
        }

        public static bool IsOpen = false;
        public static bool IsLogin = false;
        public static bool IsBackFromLogin = false;

        private void AvailabilityChanged(object sender, NetworkAvailabilityEventArgs e)
        {
                if (!e.IsAvailable)
                {
                LogErrors.LogWrite(LogErrors.NoInternetConnection);
                Environment.Exit(0);
                }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            WithoutInternetConnection.NoConnectionMsg();
        }

        private void ConnectBtn_Click(object sender, EventArgs e)
        {
            if (IsLogin != true)
            {
                Login frmLogin = new Login();
                frmLogin.ShowDialog();
            }
            else
            {
                ConnectBtn.Text = "PAINEL";

                if(IsOpen != true)
                {
                    IsOpen = true;
                    frmMain frm = new frmMain();
                    frm.Show();
                }else
                {
                    //null
                }

            }
        }

        private void Loading_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void MainLogin_Activated(object sender, EventArgs e)
        {
            if (IsBackFromLogin == true)
            {
                ConnectBtn_Click(null, null);
                IsBackFromLogin = false;
            }
        }
    }
}
