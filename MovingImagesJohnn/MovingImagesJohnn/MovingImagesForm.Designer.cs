namespace MovingImagesJohnn
{
    partial class frmMovingImages
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
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tekashiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tekashi691ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tekashi692ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.picTekashi = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTekashi)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.tekashiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(519, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.fileToolStripMenuItem.Text = "File ";
            // 
            // tekashiToolStripMenuItem
            // 
            this.tekashiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tekashi691ToolStripMenuItem,
            this.tekashi692ToolStripMenuItem});
            this.tekashiToolStripMenuItem.Name = "tekashiToolStripMenuItem";
            this.tekashiToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.tekashiToolStripMenuItem.Text = "Tekashi69";
            // 
            // tekashi691ToolStripMenuItem
            // 
            this.tekashi691ToolStripMenuItem.Name = "tekashi691ToolStripMenuItem";
            this.tekashi691ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.tekashi691ToolStripMenuItem.Text = "Tekashi1";
            this.tekashi691ToolStripMenuItem.Click += new System.EventHandler(this.tekashi691ToolStripMenuItem_Click);
            // 
            // tekashi692ToolStripMenuItem
            // 
            this.tekashi692ToolStripMenuItem.Name = "tekashi692ToolStripMenuItem";
            this.tekashi692ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.tekashi692ToolStripMenuItem.Text = "Tekashi2";
            this.tekashi692ToolStripMenuItem.Click += new System.EventHandler(this.tekashi692ToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // picTekashi
            // 
            this.picTekashi.Image = global::MovingImagesJohnn.Properties.Resources._1;
            this.picTekashi.Location = new System.Drawing.Point(108, 70);
            this.picTekashi.Name = "picTekashi";
            this.picTekashi.Size = new System.Drawing.Size(285, 412);
            this.picTekashi.TabIndex = 0;
            this.picTekashi.TabStop = false;
            // 
            // frmMovingImages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(519, 522);
            this.Controls.Add(this.picTekashi);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMovingImages";
            this.Text = "Moving Images";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTekashi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picTekashi;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tekashiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tekashi691ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tekashi692ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

