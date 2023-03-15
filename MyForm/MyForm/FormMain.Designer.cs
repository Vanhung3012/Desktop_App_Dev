namespace MyForm
{
    partial class FormMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hồVănHưngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiVD1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiVD2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hồVănHưngToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hồVănHưngToolStripMenuItem
            // 
            this.hồVănHưngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiVD1,
            this.tsmiVD2});
            this.hồVănHưngToolStripMenuItem.Name = "hồVănHưngToolStripMenuItem";
            this.hồVănHưngToolStripMenuItem.Size = new System.Drawing.Size(112, 24);
            this.hồVănHưngToolStripMenuItem.Text = "Hồ Văn Hưng";
            // 
            // tsmiVD1
            // 
            this.tsmiVD1.Name = "tsmiVD1";
            this.tsmiVD1.Size = new System.Drawing.Size(224, 26);
            this.tsmiVD1.Text = "Ví dụ 1";
            this.tsmiVD1.Click += new System.EventHandler(this.tsmiVD1_Click);
            // 
            // tsmiVD2
            // 
            this.tsmiVD2.Name = "tsmiVD2";
            this.tsmiVD2.Size = new System.Drawing.Size(224, 26);
            this.tsmiVD2.Text = "Ví dụ 2";
            this.tsmiVD2.Click += new System.EventHandler(this.tsmiVD2_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "Chương trình chính";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hồVănHưngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiVD1;
        private System.Windows.Forms.ToolStripMenuItem tsmiVD2;
    }
}

