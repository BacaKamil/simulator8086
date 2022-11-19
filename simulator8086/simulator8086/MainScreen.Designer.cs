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
            this.SuspendLayout();
            // 
            // MOVbutt
            // 
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
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(804, 54);
            this.label1.TabIndex = 3;
            this.label1.Text = "SIMULATOR 8086";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 451);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.XCHGbutt);
            this.Controls.Add(this.MOVbutt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MainScreen";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simulator 8086";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button MOVbutt;
        private Button XCHGbutt;
        private Label label1;
    }
}