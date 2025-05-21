using System.Runtime.CompilerServices;

namespace EventsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Button wurde geklickt!");
        }

        private void MeinCustomEventHandler(object sender, EventArgs e)
        {
            label1.Text = $"Der Button wurde um {DateTime.Now.ToLongTimeString()} geklickt!";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i = 1;
            i = i + 1;
            i += 1;

            button1.Click += MeinCustomEventHandler;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1.Click -= MeinCustomEventHandler;
        }
    }
}
