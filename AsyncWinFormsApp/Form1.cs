using System;
namespace AsyncWinFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string fileName = "C:\\Windows\\Media\\notify.wav"; // Path to your sound file
            InteropHelper.PlaySound(fileName, 1);

            await DemoMethodAsync();
            label1.Text = "Task Completed!";
            NormalMethod();
        }

        private async Task DemoMethodAsync()
        {
            


            await Task.Delay(10000);
            // Simulate a long-running task
        }

        private void NormalMethod()
        {
            // This method runs on the UI thread
            Thread.Sleep(10000); // Simulate a long-running task
            label1.Text = "Normal Method Executed!";
        }

    }
}
