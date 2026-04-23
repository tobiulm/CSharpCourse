using NewElements.DemoLibrary;

namespace HRWinFormsApp
{
    public partial class Form1 : Form
    {
        internal static Mitarbeiter Mitarbeiter;

        public Form1()
        {
            InitializeComponent();
            Mitarbeiter = new Mitarbeiter();
            abteilungComboBox.DataSource = Enum.GetValues<Abteilungen>();

            CustomEventsForm ereignisForm = new CustomEventsForm();
            ereignisForm.Show();
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

        private void abteilungComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Mitarbeiter.Abteilung = Enum.Parse<Abteilungen>(abteilungComboBox.Text);

            abteilungLabel.Text = Mitarbeiter.Abteilung.ToString(); 
        }
    }
}