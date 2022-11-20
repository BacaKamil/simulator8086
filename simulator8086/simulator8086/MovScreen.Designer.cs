namespace simulator8086
{
    partial class MovScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BackButt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.bx_value = new System.Windows.Forms.Label();
            this.cx_value = new System.Windows.Forms.Label();
            this.dx_value = new System.Windows.Forms.Label();
            this.ax_value = new System.Windows.Forms.Label();
            this.exec_button = new System.Windows.Forms.Button();
            this.ax1 = new System.Windows.Forms.RadioButton();
            this.bx1 = new System.Windows.Forms.RadioButton();
            this.cx1 = new System.Windows.Forms.RadioButton();
            this.dx1 = new System.Windows.Forms.RadioButton();
            this.ax2 = new System.Windows.Forms.RadioButton();
            this.bx2 = new System.Windows.Forms.RadioButton();
            this.cx2 = new System.Windows.Forms.RadioButton();
            this.dx2 = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.reset_button = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cansel_button = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // BackButt
            // 
            this.BackButt.Location = new System.Drawing.Point(640, 370);
            this.BackButt.Name = "BackButt";
            this.BackButt.Size = new System.Drawing.Size(120, 50);
            this.BackButt.TabIndex = 0;
            this.BackButt.Text = "BACK";
            this.BackButt.UseVisualStyleBackColor = true;
            this.BackButt.Click += new System.EventHandler(this.BackButt_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(800, 55);
            this.label1.TabIndex = 2;
            this.label1.Text = "MOV";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(257, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 28);
            this.label2.TabIndex = 11;
            this.label2.Text = "TO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(106, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 28);
            this.label3.TabIndex = 12;
            this.label3.Text = "FROM";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(473, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 28);
            this.label4.TabIndex = 13;
            this.label4.Text = "AX =";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(473, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 28);
            this.label5.TabIndex = 14;
            this.label5.Text = "BX =";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(473, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 28);
            this.label6.TabIndex = 15;
            this.label6.Text = "CX =";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(473, 305);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 28);
            this.label7.TabIndex = 16;
            this.label7.Text = "DX =";
            // 
            // bx_value
            // 
            this.bx_value.AutoSize = true;
            this.bx_value.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bx_value.Location = new System.Drawing.Point(533, 215);
            this.bx_value.Name = "bx_value";
            this.bx_value.Size = new System.Drawing.Size(17, 28);
            this.bx_value.TabIndex = 18;
            this.bx_value.Text = " ";
            // 
            // cx_value
            // 
            this.cx_value.AutoSize = true;
            this.cx_value.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cx_value.Location = new System.Drawing.Point(533, 260);
            this.cx_value.Name = "cx_value";
            this.cx_value.Size = new System.Drawing.Size(17, 28);
            this.cx_value.TabIndex = 19;
            this.cx_value.Text = " ";
            // 
            // dx_value
            // 
            this.dx_value.AutoSize = true;
            this.dx_value.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dx_value.Location = new System.Drawing.Point(533, 305);
            this.dx_value.Name = "dx_value";
            this.dx_value.Size = new System.Drawing.Size(17, 28);
            this.dx_value.TabIndex = 20;
            this.dx_value.Text = " ";
            // 
            // ax_value
            // 
            this.ax_value.AutoSize = true;
            this.ax_value.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ax_value.Location = new System.Drawing.Point(533, 170);
            this.ax_value.Name = "ax_value";
            this.ax_value.Size = new System.Drawing.Size(17, 28);
            this.ax_value.TabIndex = 21;
            this.ax_value.Text = " ";
            // 
            // exec_button
            // 
            this.exec_button.Location = new System.Drawing.Point(221, 361);
            this.exec_button.Name = "exec_button";
            this.exec_button.Size = new System.Drawing.Size(120, 50);
            this.exec_button.TabIndex = 22;
            this.exec_button.Text = "EXECUTE";
            this.exec_button.UseVisualStyleBackColor = true;
            this.exec_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // ax1
            // 
            this.ax1.Appearance = System.Windows.Forms.Appearance.Button;
            this.ax1.Location = new System.Drawing.Point(20, 21);
            this.ax1.Name = "ax1";
            this.ax1.Size = new System.Drawing.Size(90, 40);
            this.ax1.TabIndex = 23;
            this.ax1.TabStop = true;
            this.ax1.Text = "AX";
            this.ax1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ax1.UseVisualStyleBackColor = true;
            this.ax1.CheckedChanged += new System.EventHandler(this.ax1_CheckedChanged);
            // 
            // bx1
            // 
            this.bx1.Appearance = System.Windows.Forms.Appearance.Button;
            this.bx1.Location = new System.Drawing.Point(20, 67);
            this.bx1.Name = "bx1";
            this.bx1.Size = new System.Drawing.Size(90, 40);
            this.bx1.TabIndex = 24;
            this.bx1.TabStop = true;
            this.bx1.Text = "BX";
            this.bx1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bx1.UseVisualStyleBackColor = true;
            this.bx1.CheckedChanged += new System.EventHandler(this.bx1_CheckedChanged);
            // 
            // cx1
            // 
            this.cx1.Appearance = System.Windows.Forms.Appearance.Button;
            this.cx1.Location = new System.Drawing.Point(20, 113);
            this.cx1.Name = "cx1";
            this.cx1.Size = new System.Drawing.Size(90, 40);
            this.cx1.TabIndex = 25;
            this.cx1.TabStop = true;
            this.cx1.Text = "CX";
            this.cx1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cx1.UseVisualStyleBackColor = true;
            this.cx1.CheckedChanged += new System.EventHandler(this.cx1_CheckedChanged);
            // 
            // dx1
            // 
            this.dx1.Appearance = System.Windows.Forms.Appearance.Button;
            this.dx1.Location = new System.Drawing.Point(20, 159);
            this.dx1.Name = "dx1";
            this.dx1.Size = new System.Drawing.Size(90, 40);
            this.dx1.TabIndex = 26;
            this.dx1.TabStop = true;
            this.dx1.Text = "DX";
            this.dx1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dx1.UseVisualStyleBackColor = true;
            this.dx1.CheckedChanged += new System.EventHandler(this.dx1_CheckedChanged);
            // 
            // ax2
            // 
            this.ax2.Appearance = System.Windows.Forms.Appearance.Button;
            this.ax2.Location = new System.Drawing.Point(20, 21);
            this.ax2.Name = "ax2";
            this.ax2.Size = new System.Drawing.Size(90, 40);
            this.ax2.TabIndex = 27;
            this.ax2.TabStop = true;
            this.ax2.Text = "AX";
            this.ax2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ax2.UseVisualStyleBackColor = true;
            this.ax2.CheckedChanged += new System.EventHandler(this.ax2_CheckedChanged);
            // 
            // bx2
            // 
            this.bx2.Appearance = System.Windows.Forms.Appearance.Button;
            this.bx2.Location = new System.Drawing.Point(20, 67);
            this.bx2.Name = "bx2";
            this.bx2.Size = new System.Drawing.Size(90, 40);
            this.bx2.TabIndex = 28;
            this.bx2.TabStop = true;
            this.bx2.Text = "BX";
            this.bx2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bx2.UseVisualStyleBackColor = true;
            this.bx2.CheckedChanged += new System.EventHandler(this.bx2_CheckedChanged);
            // 
            // cx2
            // 
            this.cx2.Appearance = System.Windows.Forms.Appearance.Button;
            this.cx2.Location = new System.Drawing.Point(20, 113);
            this.cx2.Name = "cx2";
            this.cx2.Size = new System.Drawing.Size(90, 40);
            this.cx2.TabIndex = 29;
            this.cx2.TabStop = true;
            this.cx2.Text = "CX";
            this.cx2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cx2.UseVisualStyleBackColor = true;
            this.cx2.CheckedChanged += new System.EventHandler(this.cx2_CheckedChanged);
            // 
            // dx2
            // 
            this.dx2.Appearance = System.Windows.Forms.Appearance.Button;
            this.dx2.Location = new System.Drawing.Point(20, 159);
            this.dx2.Name = "dx2";
            this.dx2.Size = new System.Drawing.Size(90, 40);
            this.dx2.TabIndex = 30;
            this.dx2.TabStop = true;
            this.dx2.Text = "DX";
            this.dx2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dx2.UseVisualStyleBackColor = true;
            this.dx2.CheckedChanged += new System.EventHandler(this.dx2_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ax1);
            this.panel1.Controls.Add(this.bx1);
            this.panel1.Controls.Add(this.cx1);
            this.panel1.Controls.Add(this.dx1);
            this.panel1.Location = new System.Drawing.Point(75, 122);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(130, 220);
            this.panel1.TabIndex = 31;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ax2);
            this.panel2.Controls.Add(this.bx2);
            this.panel2.Controls.Add(this.dx2);
            this.panel2.Controls.Add(this.cx2);
            this.panel2.Location = new System.Drawing.Point(211, 122);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(130, 220);
            this.panel2.TabIndex = 32;
            // 
            // reset_button
            // 
            this.reset_button.Location = new System.Drawing.Point(75, 361);
            this.reset_button.Name = "reset_button";
            this.reset_button.Size = new System.Drawing.Size(120, 50);
            this.reset_button.TabIndex = 33;
            this.reset_button.Text = "RESET";
            this.reset_button.UseVisualStyleBackColor = true;
            this.reset_button.Click += new System.EventHandler(this.reset_button_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Controls.Add(this.cansel_button);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 30);
            this.panel3.TabIndex = 34;
            // 
            // cansel_button
            // 
            this.cansel_button.BackColor = System.Drawing.Color.Red;
            this.cansel_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cansel_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cansel_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cansel_button.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cansel_button.ForeColor = System.Drawing.Color.White;
            this.cansel_button.Location = new System.Drawing.Point(766, 3);
            this.cansel_button.Margin = new System.Windows.Forms.Padding(0);
            this.cansel_button.Name = "cansel_button";
            this.cansel_button.Size = new System.Drawing.Size(30, 25);
            this.cansel_button.TabIndex = 35;
            this.cansel_button.Text = "X";
            this.cansel_button.UseVisualStyleBackColor = false;
            this.cansel_button.Click += new System.EventHandler(this.cansel_button_Click);
            // 
            // MovScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.reset_button);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.exec_button);
            this.Controls.Add(this.ax_value);
            this.Controls.Add(this.dx_value);
            this.Controls.Add(this.cx_value);
            this.Controls.Add(this.bx_value);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BackButt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "MovScreen";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simulator 8086";
            this.Load += new System.EventHandler(this.MovScreen_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button BackButt;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label bx_value;
        private Label cx_value;
        private Label dx_value;
        private Button exec_button;
        private RadioButton ax1;
        private RadioButton bx1;
        private RadioButton cx1;
        private RadioButton dx1;
        private RadioButton ax2;
        private RadioButton bx2;
        private RadioButton cx2;
        private RadioButton dx2;
        private Panel panel1;
        private Panel panel2;
        private Button reset_button;
        private Label ax_value;
        private Panel panel3;
        private Button cansel_button;
    }
}