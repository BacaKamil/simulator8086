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
            this.SuspendLayout();
            // 
            // BackButt
            // 
            this.BackButt.Location = new System.Drawing.Point(470, 338);
            this.BackButt.Name = "BackButt";
            this.BackButt.Size = new System.Drawing.Size(194, 75);
            this.BackButt.TabIndex = 0;
            this.BackButt.Text = "BACK";
            this.BackButt.UseVisualStyleBackColor = true;
            this.BackButt.Click += new System.EventHandler(this.BackButt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(296, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 54);
            this.label1.TabIndex = 1;
            this.label1.Text = "MOV";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // MovScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BackButt);
            this.MaximizeBox = false;
            this.Name = "MovScreen";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simulator 8086";
            this.Load += new System.EventHandler(this.MovScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button BackButt;
        private Label label1;
    }
}