/*
 * Created by: John Ngundeng
 * Created on: September 18, 2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #8 - Moving Images
 * This program changes between 2 images when the menu item is clicked 
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovingImagesJohnn
{
    public partial class frmMovingImages : Form
    {
        public frmMovingImages()
        {
            InitializeComponent();
        }

        private void tekashi691ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // this makes the image change to tekashi 1 
            this.picTekashi.Image = Properties.Resources._1;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // when exit is clicked the program will close
            this.Close();
        }

        private void tekashi692ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // This makes the image change to tekashi 2
            this.picTekashi.Image = Properties.Resources._2;
        }
    }
}
