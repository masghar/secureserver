using System;
using System.Windows.Forms;

namespace MySecureServer
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
         static System.Threading.Mutex mutex = new System.Threading.Mutex(true, "{8F6F0AC4-B9A1-45fd-A8CF-72F04E6BDE8F}");
        [STAThread]
        static void Main()
        {

            if (mutex.WaitOne(TimeSpan.Zero, true))
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new frmMain());
                mutex.ReleaseMutex();
            }
            else
            {
                MessageBox.Show("Application is already running");
            }

           
            
        }
    }
}
