using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LEARNING_ASYNC_MULTITHREAD_PROGRAMMING.MultiThread
{
    public partial class MultiThreadForm2 : Form
    {
        public MultiThreadForm2()
        {
            InitializeComponent();
            
            backgroundWorker.WorkerReportsProgress = true;

            backgroundWorker.WorkerSupportsCancellation = true;
        }


        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            // Change the value of the ProgressBar to the BackgroundWorker progress.
            progressBar1.Value = e.ProgressPercentage;

            // Set the text.
            stopWatchLabel.Text = 
                $"% {e.ProgressPercentage.ToString()}";
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            var backgroundWorker = 
                sender as BackgroundWorker;

            for (int i = 1; i <= 100; i++)
            {
                // Wait 100 milliseconds.
                Thread.Sleep(100);

                // Report progress.
                backgroundWorker.ReportProgress(i);

                if (backgroundWorker.CancellationPending)
                {
                    // this is important as it set the cancelled property of RunWorkerCompletedEventArgs to true
                    e.Cancel = true;
                    break;
                }
            }

            //for (int j = 0; j < 100000; j++)
            //{
            //    Calculate(j);
            //    backgroundWorker.ReportProgress((j * 100) / 100000);
            //}
            //DateTime startTime = DateTime.Now;

            //_keepRunning = true;

            //while (_keepRunning)
            //{
            //    Thread.Sleep(1000);

            //    string timeElapsedInstring = (DateTime.Now - startTime).ToString(@"hh\:mm\:ss");

            //    backgroundWorker.ReportProgress(0, timeElapsedInstring);

        
        
    }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                stopWatchLabel.Text = "Cancelled";
            }
            else
            {
                stopWatchLabel.Text = "Completed...";
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            backgroundWorker.RunWorkerAsync();
        }

     
        private void cancelButton_Click(object sender, EventArgs e)
        {
            backgroundWorker.CancelAsync();
        }
      
    }
}
