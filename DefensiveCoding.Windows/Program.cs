using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DefensiveCoding.Windows
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // For UI thread exceptions
            Application.ThreadException +=
                new ThreadExceptionEventHandler(GlobalExceptionHandler);

            // Force all Windows Forms errors to go through our handler.
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);

            // For non-UI thread exceptions
            AppDomain.CurrentDomain.UnhandledException +=
                new UnhandledExceptionEventHandler(GlobalExceptionHandler);

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new PedometerForm());
        }

        static void GlobalExceptionHandler(object sender, EventArgs args)
        {
            // Log the issue
            MessageBox.Show("There was a problem with this application. Please contact support.");
            Application.Exit();
        }
    }
}
