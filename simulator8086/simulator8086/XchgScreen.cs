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
    public partial class XchgScreen : Form
    {
        MainScreen main = new MainScreen();

        public XchgScreen()
        {
            InitializeComponent();
        }

        private void XchgScreen_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            main.Show();
        }
    }
}
