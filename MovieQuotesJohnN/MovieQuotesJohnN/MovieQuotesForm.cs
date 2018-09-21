
/*
 * Created by: John Ngundeng
 * Created on: September 14 2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #7 - Movie quotes 
 * This program changes the labels when the menu items are clicked 
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

namespace MovieQuotesJohnN
{
    public partial class frmMovieQuotes : Form
    {
        public frmMovieQuotes()
        {
            InitializeComponent();
        }

        private void forestGumpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void theWizardOfOzToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Text for the wizard of oz
            lblMovie.Text = "The Wizard Of Oz";
            lblQuote.Text = "''Theres no place like home.''";
        }

        private void scarfaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Text for scarface
            lblMovie.Text = "ScarFace";
            lblQuote.Text = "''Say hello to my little friend.''";

        }

        private void theTerminatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Text for the terminator
            lblMovie.Text = "The Terminator";
            lblQuote.Text = "''I'll be back.''";
        }

        private void theShiningToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Text for the shining
            lblMovie.Text = "The Shining";
            lblQuote.Text = "''Here's Johnny!''";
        }

        private void starWarsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Text for star wars
            lblMovie.Text = "Star Wars";
            lblQuote.Text = "''May the force be with you.''";
        }
    }
}
