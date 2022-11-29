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
        public int AX1 = 1;
        public int BX1 = 2;
        public int CX1 = 3;
        public int DX1 = 4;

        public int from1;
        public int to1;

        public XchgScreen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ref int to = ref to1;
            ref int from = ref from1;
            ref int AX = ref AX1;
            ref int BX = ref BX1;
            ref int CX = ref CX1;
            ref int DX = ref DX1;

            AX = 1;
            BX = 2;
            CX = 3;
            DX = 4;
            ax_value.Text = " ";
            bx_value.Text = " ";
            cx_value.Text = " ";
            dx_value.Text = " ";

            ax1.Checked = false;
            bx1.Checked = false;
            cx1.Checked = false;
            dx1.Checked = false;
            ax2.Checked = false;
            bx2.Checked = false;
            cx2.Checked = false;
            dx2.Checked = false;

            MainScreen mainScreen = new MainScreen();
            this.Visible = false;
            mainScreen.Show();
        }

        private void cansel_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ax1_CheckedChanged(object sender, EventArgs e)
        {
            ref int to = ref to1;

            ref int AX = ref AX1;
            to = AX;
        }

        private void bx1_CheckedChanged(object sender, EventArgs e)
        {
            ref int to = ref to1;

            ref int BX = ref BX1;

            to = BX;
        }

        private void cx1_CheckedChanged(object sender, EventArgs e)
        {
            ref int CX = ref CX1;
            ref int to = ref to1;

            to = CX;
        }

        private void dx1_CheckedChanged(object sender, EventArgs e)
        {
            ref int DX = ref DX1;
            ref int to = ref to1;

            to = DX;
        }

        private void XchgScreen_Load(object sender, EventArgs e)
        {

        }

        private void ax2_CheckedChanged(object sender, EventArgs e)
        {
            ref int AX = ref AX1;
            ref int from = ref from1;

            from = AX;
        }

        private void bx2_CheckedChanged(object sender, EventArgs e)
        {
            ref int BX = ref BX1;
            ref int from = ref from1;

            from = BX;
        }

        private void cx2_CheckedChanged(object sender, EventArgs e)
        {
            ref int CX = ref CX1;
            ref int from = ref from1;

            from = CX;
        }

        private void dx2_CheckedChanged(object sender, EventArgs e)
        {
            ref int DX = ref DX1;
            ref int from = ref from1;

            from = DX;
        }

        private void exec_button_Click(object sender, EventArgs e)
        {
            ref int to = ref to1;
            ref int from = ref from1;
            ref int AX = ref AX1;
            ref int BX = ref BX1;
            ref int CX = ref CX1;
            ref int DX = ref DX1;

            if (to == AX)
            {

                if (from == AX)
                {

                    AX = to;
                    AX = from;
                }
                else if (from == BX)
                {
                    BX = to;
                    AX = from;
                }
                else if (from == CX)
                {
                    CX = to;
                    AX = from;
                }
                else if (from == DX)
                {
                    DX = to;
                    AX = from;
                }

            }
            else if (to == BX)
            {

                if (from == AX)
                {
                    AX = to;
                    BX = from;

                }
                else if (from == BX)
                {
                    BX = to;
                    BX = from;
                }
                else if (from == CX)
                {
                    CX = to;
                    BX = from;
                }
                else if (from == DX)
                {
                    DX = to;
                    BX = from;
                }
            }
            else if (to == CX)
            {
                if (from == AX)
                {
                    AX = to;
                    CX = from;


                }
                else if (from == BX)
                {
                    BX = to;
                    CX = from;

                }
                else if (from == CX)
                {
                    CX = to;
                    CX = from;

                }
                else if (from == DX)
                {
                    DX = to;
                    CX = from;

                }
            }
            else if (to == DX)
            {
                if (from == AX)
                {
                    AX = to;
                    DX = from;


                }
                else if (from == BX)
                {
                    BX = to;
                    DX = from;

                }
                else if (from == CX)
                {
                    CX = to;
                    DX = from;

                }
                else if (from == DX)
                {
                    DX = to;
                    DX = from;

                }
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

        private void reset_button_Click(object sender, EventArgs e)
        {
            ref int to = ref to1;
            ref int from = ref from1;
            ref int AX = ref AX1;
            ref int BX = ref BX1;
            ref int CX = ref CX1;
            ref int DX = ref DX1;

            AX = 1;
            BX = 2;
            CX = 3;
            DX = 4;
            ax_value.Text = " ";
            bx_value.Text = " ";
            cx_value.Text = " ";
            dx_value.Text = " ";

            ax1.Checked = false;
            bx1.Checked = false;
            cx1.Checked = false;
            dx1.Checked = false;
            ax2.Checked = false;
            bx2.Checked = false;
            cx2.Checked = false;
            dx2.Checked = false;
        }
        private void MovScreen_Load(object sender, EventArgs e)
        {
            ref int AX = ref AX1;
            ref int BX = ref BX1;
            ref int CX = ref CX1;
            ref int DX = ref DX1;
            ax_value.Text = AX.ToString();
            bx_value.Text = BX.ToString();
            cx_value.Text = CX.ToString();
            dx_value.Text = DX.ToString();
        }
    }
}
