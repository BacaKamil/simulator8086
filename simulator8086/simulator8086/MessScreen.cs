using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simulator8086
{
    public partial class MessScreen : Form
    {
        public MessScreen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainScreen mainScreen = new MainScreen();
            this.Visible = false;
            mainScreen.Show();
        }
    }
}
