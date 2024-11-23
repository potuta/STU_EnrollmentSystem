using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STUEnrollmentSystem
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ConnectionFactory.SetConnectionString(Properties.Settings.Default.STU_DBConnectionString);

            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                LoggingService.LogInformation("System started.");
                Application.Run(new frmLogin());
            }
            finally
            {
                LoggingService.LogInformation("System shutdown.");
                LoggingService.Shutdown();
                Thread.Sleep(1000);
            }
        }
    }
}
