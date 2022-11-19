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
    public partial class MovScreen : Form
    {
        public int AX = 1;
        public int BX = 2;
        public int CX = 3;
        public int DX = 4;

        public int from;
        public int to;

        public MovScreen()
        {
            InitializeComponent();
        }

        private void MovScreen_Load(object sender, EventArgs e)
        {

        }

        private void BackButt_Click(object sender, EventArgs e)
        {
            MainScreen mainScreen = new MainScreen();
            this.Visible = false;
            mainScreen.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (to == AX)
            {
                AX = from;

            }
            else if (to == BX)
            {
                BX = from;

            }
            else if (to == CX)
            {
                CX = from;

            }
            else if (to == DX)
            {
                DX = from;

            }
            ax_value.Text = AX.ToString();
            bx_value.Text = BX.ToString();
            cx_value.Text = CX.ToString();
            dx_value.Text = DX.ToString();
            ax1.Checked = false;
            bx1.Checked = false;
            cx1.Checked = false;
            dx1.Checked = false;
            ax2.Checked = false;
            bx2.Checked = false;
            cx2.Checked = false;
            dx2.Checked = false;
        }

        private void ax1_CheckedChanged(object sender, EventArgs e)
        {
            from = AX;
        }

        private void bx1_CheckedChanged(object sender, EventArgs e)
        {
            from = BX;
        }

        private void cx1_CheckedChanged(object sender, EventArgs e)
        {
            from = CX;
        }

        private void dx1_CheckedChanged(object sender, EventArgs e)
        {
            from = DX;
        }

        private void ax2_CheckedChanged(object sender, EventArgs e)
        {
            to = AX;
        }

        private void bx2_CheckedChanged(object sender, EventArgs e)
        {
            to = BX;
        }

        private void cx2_CheckedChanged(object sender, EventArgs e)
        {
            to = CX; 
        }

        private void dx2_CheckedChanged(object sender, EventArgs e)
        {
            to = DX;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void reset_button_Click(object sender, EventArgs e)
        {
            ax1.Checked = false;
            bx1.Checked = false;
            cx1.Checked = false;
            dx1.Checked = false;
            ax2.Checked = false;
            bx2.Checked = false;
            cx2.Checked = false;
            dx2.Checked = false;
            AX = 1;
            BX = 2;
            CX = 3;
            DX = 4;
            ax_value.Text = null;
            bx_value.Text = null;
            cx_value.Text = null;
            dx_value.Text = null;
        }
    }
}
