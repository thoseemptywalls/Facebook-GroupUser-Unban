using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace fbook
{
    public partial class WithoutInternetConnection : MaterialForm
    {
        public WithoutInternetConnection()
        {
            InitializeComponent();
        }

        public class InternetAvailability
        {
            [DllImport("wininet.dll")]
            private extern static bool InternetGetConnectedState(out int description, int reservedValue);

            public static bool IsInternetAvailable()
            {
                int description;
                return InternetGetConnectedState(out description, 0);
            }
        }

        public static void NoConnectionMsg()
        {
            //Check if internet is ok
            WithoutInternetConnection NoConnection = new WithoutInternetConnection();
            if (!InternetAvailability.IsInternetAvailable())
            {
                NoConnection.ShowDialog();
            }
        }

        private void WithoutInternetConnection_Load(object sender, EventArgs e)
        {
            LogErrors.LogWrite(LogErrors.NIC_OnStart);
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void WithoutInternetConnection_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
