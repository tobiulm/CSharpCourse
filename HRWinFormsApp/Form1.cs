namespace HRWinFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void mainButton_Click(object sender, EventArgs e)
        {
            outputLabel.Text = $"Der Button wurde um {DateTime.Now.ToLongTimeString()} geklickt!";
        }


        private void Helga(object sender, EventArgs e)
        {
            MessageBox.Show("Yippi! Event Handler Helga ausgeführt...");
        }

        private void eventHandlerAnfügenButton_Click(object sender, EventArgs e)
        {
            mainButton.Click += Helga;
        }

        private void eventHandlerLösenButton_Click(object sender, EventArgs e)
        {
            mainButton.Click -= Helga;
        }
    }
}