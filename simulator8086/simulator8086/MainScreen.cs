namespace simulator8086
{
    public partial class MainScreen : Form
    {
        
        

        public MainScreen()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void MOVbutt_Click(object sender, EventArgs e)
        {
            MovScreen movScreen = new MovScreen();
            this.Visible = false;
            movScreen.Show();
        }

        private void XCHGbutt_Click(object sender, EventArgs e)
        {
            XchgScreen xchgScreen = new XchgScreen();

            this.Visible=false;
            xchgScreen.Show();
        }
    }
}