using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fbook
{
    public class LogErrors
    {
        //
        //desc
        //

        private static string hour_date = " | " + DateTime.Now.ToString("h:mm:ss tt") + " | " + DateTime.Now.ToString("d/M/yyyy]");

        //#00001 Internet Connection Closed
        public static string NoInternetConnection = 
            "[[#ex00001] AvailabilityChanged: The internet connection was lost. The application was forced to close." + hour_date;
        //#00002 No Internet Connection
        public static string NIC_OnStart =
            "[[#ex00002] NoConnection: Started application but there's no internet connection. The application was forced to close." + hour_date;      
        //#00004 Timed Out
        public static string TimeOut =
            "[[#ex00004] TimeOut: The operation took too long to complete and was automatically closed. Possible causes may be: Slow connection/Server Offline/Wrong requisition. " + hour_date;
        // Exception
        public static void Excep(string name, string desc)
        {     
            string msg = "[["+ name +"] Exception: Probably an internal code error. Debug this application or contact your administrator." +" (desc: "+ desc +")"+ hour_date;
            LogWrite(msg);
        }
   


        //FileWrite
        public static async void LogWrite(string LogCode)
        {
            string path = System.AppDomain.CurrentDomain.BaseDirectory + @"\log.txt";
            if (!File.Exists(path))
            {
                File.Create(path);
                await Task.Delay(3000);
                using (var tw = new StreamWriter(path, true))
                {
                    tw.WriteLine(LogCode);
                }
            }
            else if (File.Exists(path))
            {
                using (var tw = new StreamWriter(path, true))
                {
                    tw.WriteLine(LogCode);
                }
            }
        }

    }
}
