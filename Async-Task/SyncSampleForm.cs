using Async_Task;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LEARNING_ASYNC_MULTITHREAD_PROGRAMMING.Async_Task
{
    public partial class SyncSampleForm : Form
    {
        public SyncSampleForm()
        {
            InitializeComponent();
        }

        public StringBuilder Result { get; set; }

        private void SyncSampleForm_Load(object sender, EventArgs e)
        {
            Result = new StringBuilder();
        }

        private void SyncButton_Click(object sender, EventArgs e)
        {
            Coffee cup = PourCoffee();
            ShowResult("---------------");
            ShowResult("coffee is ready");

            Egg eggs = FryEggs(2);
            ShowResult("---------------");
            ShowResult("eggs are ready");

            Toast toast = ToastBread(2);
            ApplyButter(toast);
            ApplyJam(toast);
            ShowResult("---------------");
            ShowResult("toast is ready");

            Juice oj = PourOJ();
            ShowResult("---------------");
            ShowResult("oj is ready");
            ShowResult("---------------");
            ShowResult("---------------");
            ShowResult("Breakfast is ready!");
        }

        private Juice PourOJ()
        {
            Task.Delay(5000).Wait();

            ShowResult("                       ");
            ShowResult("Pouring orange juice...");

            return new Juice();
        }

        private void ApplyJam(Toast toast)
        {
            ShowResult("                       ");
            ShowResult("Putting jam on the toast...");
        }


        private void ApplyButter(Toast toast)
        {
            ShowResult("                       ");
            ShowResult("Putting butter on the toast...");
        }

        private Toast ToastBread(int slices)
        {
            for (int slice = 0; slice < slices; slice++)
            {
                ShowResult("Putting a slice of bread in the toaster...");
            }

            ShowResult("Start toasting...");
           
            Task.Delay(10000).Wait();

            ShowResult("Remove toast from toaster...");
        
            return new Toast();
        }


        private Egg FryEggs(int howMany)
        {
            ShowResult("Warming the egg pan...");

            Task.Delay(10000).Wait();

            ShowResult($"cracking {howMany} eggs");

            ShowResult("cooking the eggs ...");

            Task.Delay(10000).Wait();

            ShowResult("Put eggs on plate");

            return new Egg();
        }

        private Coffee PourCoffee()
        {
       
            ShowResult("Pouring coffee...");
            Task.Delay(6000).Wait();

            return new Coffee();
        }

        private void ShowResult(string result)
        {
            Result.Append(result);
            Result.AppendLine();

            resultTextBox.Text =
                Result.ToString();
        }
    }
}
