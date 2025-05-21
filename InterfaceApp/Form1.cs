using InterfaceLibrary;
namespace InterfaceApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IPerson person = new DemoLibrary.Person();
            person.FirstName = textBox1.Text;
            person.LastName = textBox2.Text;

            label1.Text = person.SayHello();

        }
    }
}
