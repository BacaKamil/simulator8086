namespace simulator8086
{
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();  
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

        private void cansel_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}