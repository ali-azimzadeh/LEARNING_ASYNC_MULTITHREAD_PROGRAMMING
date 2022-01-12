using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LEARNING_ASYNC_MULTITHREAD_PROGRAMMING.Async_Task
{
    public partial class AsyncSampleForm2 : Form
    {
        public AsyncSampleForm2()
        {
            InitializeComponent();
        }

        private async void AsyncButton_ClickAsync(object sender, EventArgs e)
        {
            resultTextBox.Text += 
                await GetUrlContentLengthAsync();
        }
        public async Task<int> GetUrlContentLengthAsync()
        {
            var client = new HttpClient();

            string contents = 
                await client.GetStringAsync("https://docs.microsoft.com/dotnet");

            await DoIndependentWorkAsync();


            //Task<string> getStringTask =
            //    client.GetStringAsync("https://docs.microsoft.com/dotnet");

            //DoIndependentWork();

            //string contents = await getStringTask;

            return contents.Length;
        }

        void DoIndependentWork()
        {
            resultTextBox.Text = "Working...";
        }

        private async Task DoIndependentWorkAsync()
        {
            resultTextBox.Text = "Working...";
        }
    }
}
