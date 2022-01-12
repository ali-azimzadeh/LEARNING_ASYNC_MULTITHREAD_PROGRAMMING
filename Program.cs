using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LEARNING_ASYNC_MULTITHREAD_PROGRAMMING
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
           // Application.Run(new Async_Task.SyncSampleForm());
           // Application.Run(new Async_Task.AsyncSampleForm());
            //Application.Run(new Async_Task.AsyncSampleForm2());
            //Application.Run(new MultiThread.MultiThreadForm1());
            Application.Run(new MultiThread.MultiThreadForm2());
        }
    }
}
