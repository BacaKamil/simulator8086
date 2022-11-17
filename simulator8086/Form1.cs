namespace simulator8086
{
    public partial class screen : Form
    {
        public screen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a;
            label1.Text = textBox1.Text.ToString();
            a = textBox1.Text;
            label2.Text = a;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void screen_Load(object sender, EventArgs e)
        {

        }

        private void screen_Load_1(object sender, EventArgs e)
        {

        }
    }
}