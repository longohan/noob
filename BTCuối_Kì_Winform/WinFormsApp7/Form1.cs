namespace WinFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            login lg = new login();
            lg.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
