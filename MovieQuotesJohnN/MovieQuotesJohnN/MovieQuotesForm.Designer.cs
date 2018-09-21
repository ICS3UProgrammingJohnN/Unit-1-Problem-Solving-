namespace MovieQuotesJohnN
{
    partial class frmMovieQuotes
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
            this.movieQuotesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scarfaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.theWizardOfOzToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.theTerminatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.theShiningToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblMovie = new System.Windows.Forms.Label();
            this.lblQuote = new System.Windows.Forms.Label();
            this.starWarsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grbMovieQuotes = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            this.grbMovieQuotes.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.movieQuotesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(580, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // movieQuotesToolStripMenuItem
            // 
            this.movieQuotesToolStripMenuItem.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.movieQuotesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.scarfaceToolStripMenuItem,
            this.theWizardOfOzToolStripMenuItem,
            this.theTerminatorToolStripMenuItem,
            this.theShiningToolStripMenuItem,
            this.starWarsToolStripMenuItem});
            this.movieQuotesToolStripMenuItem.Name = "movieQuotesToolStripMenuItem";
            this.movieQuotesToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.movieQuotesToolStripMenuItem.Text = "Movie Quotes";
            // 
            // scarfaceToolStripMenuItem
            // 
            this.scarfaceToolStripMenuItem.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.scarfaceToolStripMenuItem.Name = "scarfaceToolStripMenuItem";
            this.scarfaceToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.scarfaceToolStripMenuItem.Text = "Scarface";
            this.scarfaceToolStripMenuItem.Click += new System.EventHandler(this.scarfaceToolStripMenuItem_Click);
            // 
            // theWizardOfOzToolStripMenuItem
            // 
            this.theWizardOfOzToolStripMenuItem.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.theWizardOfOzToolStripMenuItem.Name = "theWizardOfOzToolStripMenuItem";
            this.theWizardOfOzToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.theWizardOfOzToolStripMenuItem.Text = "The Wizard of Oz";
            this.theWizardOfOzToolStripMenuItem.Click += new System.EventHandler(this.theWizardOfOzToolStripMenuItem_Click);
            // 
            // theTerminatorToolStripMenuItem
            // 
            this.theTerminatorToolStripMenuItem.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.theTerminatorToolStripMenuItem.Name = "theTerminatorToolStripMenuItem";
            this.theTerminatorToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.theTerminatorToolStripMenuItem.Text = "The Terminator";
            this.theTerminatorToolStripMenuItem.Click += new System.EventHandler(this.theTerminatorToolStripMenuItem_Click);
            // 
            // theShiningToolStripMenuItem
            // 
            this.theShiningToolStripMenuItem.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.theShiningToolStripMenuItem.Name = "theShiningToolStripMenuItem";
            this.theShiningToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.theShiningToolStripMenuItem.Text = "The Shining";
            this.theShiningToolStripMenuItem.Click += new System.EventHandler(this.theShiningToolStripMenuItem_Click);
            // 
            // lblMovie
            // 
            this.lblMovie.AutoSize = true;
            this.lblMovie.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovie.Location = new System.Drawing.Point(21, 32);
            this.lblMovie.Name = "lblMovie";
            this.lblMovie.Size = new System.Drawing.Size(50, 36);
            this.lblMovie.TabIndex = 1;
            this.lblMovie.Text = "     ";
            // 
            // lblQuote
            // 
            this.lblQuote.AutoSize = true;
            this.lblQuote.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuote.Location = new System.Drawing.Point(21, 95);
            this.lblQuote.Name = "lblQuote";
            this.lblQuote.Size = new System.Drawing.Size(64, 36);
            this.lblQuote.TabIndex = 2;
            this.lblQuote.Text = "       ";
            // 
            // starWarsToolStripMenuItem
            // 
            this.starWarsToolStripMenuItem.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.starWarsToolStripMenuItem.Name = "starWarsToolStripMenuItem";
            this.starWarsToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.starWarsToolStripMenuItem.Text = "Star Wars";
            this.starWarsToolStripMenuItem.Click += new System.EventHandler(this.starWarsToolStripMenuItem_Click);
            // 
            // grbMovieQuotes
            // 
            this.grbMovieQuotes.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.grbMovieQuotes.Controls.Add(this.lblMovie);
            this.grbMovieQuotes.Controls.Add(this.lblQuote);
            this.grbMovieQuotes.Location = new System.Drawing.Point(80, 46);
            this.grbMovieQuotes.Name = "grbMovieQuotes";
            this.grbMovieQuotes.Size = new System.Drawing.Size(439, 187);
            this.grbMovieQuotes.TabIndex = 3;
            this.grbMovieQuotes.TabStop = false;
            this.grbMovieQuotes.Text = "Movies";
            // 
            // frmMovieQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(580, 261);
            this.Controls.Add(this.grbMovieQuotes);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMovieQuotes";
            this.Text = "Movie Quotes";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grbMovieQuotes.ResumeLayout(false);
            this.grbMovieQuotes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem movieQuotesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scarfaceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem theWizardOfOzToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem theTerminatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem theShiningToolStripMenuItem;
        private System.Windows.Forms.Label lblMovie;
        private System.Windows.Forms.Label lblQuote;
        private System.Windows.Forms.ToolStripMenuItem starWarsToolStripMenuItem;
        private System.Windows.Forms.GroupBox grbMovieQuotes;
    }
}

