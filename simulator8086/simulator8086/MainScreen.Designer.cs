namespace simulator8086
{
    partial class MainScreen
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MOVbutt = new System.Windows.Forms.Button();
            this.XCHGbutt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cansel_button = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MOVbutt
            // 
            this.MOVbutt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MOVbutt.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MOVbutt.Location = new System.Drawing.Point(175, 185);
            this.MOVbutt.Name = "MOVbutt";
            this.MOVbutt.Size = new System.Drawing.Size(160, 80);
            this.MOVbutt.TabIndex = 0;
            this.MOVbutt.Text = "MOV";
            this.MOVbutt.UseVisualStyleBackColor = true;
            this.MOVbutt.Click += new System.EventHandler(this.MOVbutt_Click);
            // 
            // XCHGbutt
            // 
            this.XCHGbutt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.XCHGbutt.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.XCHGbutt.Location = new System.Drawing.Point(470, 185);
            this.XCHGbutt.Name = "XCHGbutt";
            this.XCHGbutt.Size = new System.Drawing.Size(160, 80);
            this.XCHGbutt.TabIndex = 1;
            this.XCHGbutt.Text = "XCHG";
            this.XCHGbutt.UseVisualStyleBackColor = true;
            this.XCHGbutt.Click += new System.EventHandler(this.XCHGbutt_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(800, 55);
            this.label1.TabIndex = 3;
            this.label1.Text = "SIMULATOR 8086";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.cansel_button);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 30);
            this.panel1.TabIndex = 4;
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
            this.cansel_button.TabIndex = 5;
            this.cansel_button.Text = "X";
            this.cansel_button.UseVisualStyleBackColor = false;
            this.cansel_button.Click += new System.EventHandler(this.cansel_button_Click);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.XCHGbutt);
            this.Controls.Add(this.MOVbutt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainScreen";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simulator 8086";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Button MOVbutt;
        private Button XCHGbutt;
        private Label label1;
        private Panel panel1;
        private Button cansel_button;
    }
}