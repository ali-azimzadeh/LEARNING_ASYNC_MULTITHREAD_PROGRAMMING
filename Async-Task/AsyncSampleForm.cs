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
    public partial class AsyncSampleForm : Form
    {
        public AsyncSampleForm()
        {
            InitializeComponent();
        }

        public StringBuilder Result { get; set; }

        private void AsyncSampleForm_Load(object sender, EventArgs e)
        {
            Result = new StringBuilder();
        }

        private async void AsyncButton_ClickAsync(object sender, EventArgs e)
        {
            //********************************************
            //                Solution (1)
            //********************************************

            //Coffee cup = PourCoffee();
            //ShowResult("---------------");
            //ShowResult("coffee is ready");

            //Task<Egg> eggsTask = FryEggsAsync(2);
            //Egg eggs = await eggsTask;
            //ShowResult("---------------");
            //ShowResult("eggs are ready");


            //Task<Toast> toastTask = ToastBreadAsync(2);
            //Toast toast = await toastTask;
            //ApplyButter(toast);
            //ApplyJam(toast);
            //ShowResult("---------------");
            //ShowResult("toast is ready");

            //Juice oj = PourOJ();
            //ShowResult("---------------");
            //ShowResult("oj is ready");
            //ShowResult("---------------");
            //ShowResult("---------------");
            //ShowResult("Breakfast is ready!");

            //********************************************
            //                Solution (2)
            //********************************************

            Coffee cup = PourCoffee();
            ShowResult("---------------");
            ShowResult("coffee is ready");

            var eggsTask = FryEggsAsync(2);

            var toastTask = MakeToastWithButterAndJamAsync(2);

            var breakfastTasks =
                new List<Task> { eggsTask, toastTask };

            while (breakfastTasks.Count > 0)
            {
                Task finishedTask =
                    await Task.WhenAny(breakfastTasks);

                if (finishedTask == eggsTask)
                {
                    ShowResult("---------------");
                    ShowResult("eggs are ready");
                }
                else if (finishedTask == toastTask)
                {
                    ShowResult("---------------");
                    ShowResult("toast is ready");
                }

                breakfastTasks.Remove(finishedTask);
            }

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

        private async Task<Toast> ToastBreadAsync(int slices)
        {
            for (int slice = 0; slice < slices; slice++)
            {
                ShowResult("Putting a slice of bread in the toaster...");
            }

            ShowResult("Start toasting...");

            await Task.Delay(10000);

            ShowResult("Remove toast from toaster...");

            return new Toast();
        }

        private async Task<Toast> MakeToastWithButterAndJamAsync(int number)
        {
            var toast = 
                await ToastBreadAsync(number);

            ApplyButter(toast);
            ApplyJam(toast);

            return toast;
        }
        private async Task<Egg> FryEggsAsync(int howMany)
        {
            ShowResult("Warming the egg pan...");

            await Task.Delay(5000);

            ShowResult($"cracking {howMany} eggs");

            ShowResult("cooking the eggs ...");

            await Task.Delay(10000);

            ShowResult("Put eggs on plate");

            return new Egg();
        }

        private Coffee PourCoffee()
        {

            ShowResult("Pouring coffee...");
            Task.Delay(3000).Wait();

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
