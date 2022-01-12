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
    public partial class MultiThreadForm1 : Form
    {
        public MultiThreadForm1()
        {
            InitializeComponent();
        }

        public StringBuilder Result { get; set; }

        private void MultiThreadForm1_Load(object sender, EventArgs e)
        {
            Result = new StringBuilder();

            TextBox.CheckForIllegalCrossThreadCalls = false;
        }

        private void Example1()
        {
            ShowResult("Thread1 Started...");

            for (long i = 0; i <= 90000000; i++) ;
           
            Thread.Sleep(10000); //Sleep is used to pause a thread and 5000 is MilliSeconds that means 5 Seconds    
           
            ShowResult("Thread1 Executing Finish");

        }
        private void Example2()
        {
            ShowResult("Thread2 Started...");

            for (int i = 0; i <= 5; i++)
            {
                ShowResult("Thread2 Executing");

                Thread.Sleep(5000);
            }

            ShowResult("Thread2 Executing Finish");
        }

        private void ShowResult(string result)
        {
            Result.Append(result);

            Result.AppendLine();
           
            resultTextBox.Text =
                Result.ToString();
        }

        private void MultiThreadButton_Click(object sender, EventArgs e)
        {
            Thread ThreadObject1 = 
                new Thread(Example1); //Creating the Thread
                                                         //
            Thread ThreadObject2 = 
                new Thread(Example2);

            ThreadObject1.Start(); //Starting the Thread    

            ThreadObject2.Start();
        }
    }
}
