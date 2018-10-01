/*
 * Created by: John Ngundeng
 * Created on: september 25, 2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #10 - Circumference
 * This program gets user input to get radius then calculates the radius
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

namespace CircumJohnN
{
    public partial class frmCircumference : Form
    {
        public frmCircumference()
        {
            InitializeComponent();
            // hide the answer labels 
            this.lblCircumference.Hide();
            this.lblCircumferenceAnswer.Hide();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // This closes the program when clicked
            this.Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // declaring local variable
            double radius, circumference;

            // convert the string in the text box to double
            radius = double.Parse(txtRadius.Text);

            // calculate the circumference
            circumference = 2 * 3.14 * radius;

            // insert circumference into label 
            this.lblCircumferenceAnswer.Text = Convert.ToString(circumference) + "Cm";

            // Display the hidden labels 
            this.lblCircumference.Show();
            this.lblCircumferenceAnswer.Show();
        }
    }
}
