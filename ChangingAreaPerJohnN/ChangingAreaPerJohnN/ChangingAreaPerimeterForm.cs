/*
 * Created by: John Ngundeng
 * Created on: September 19, 2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #9 - Changing Area and Perimeter
 * This program gets user input to calculate the area and perimeter. 
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

namespace ChangingAreaPerJohnN
{
    public partial class frmChangingAreaPerimeter : Form
    {
        public frmChangingAreaPerimeter()
        {
            InitializeComponent();
            // Hide the answer, area and perimeter labels
            this.lblArea.Hide();
            this.lblAreaAnswer.Hide();
            this.lblPerimeterAnswer.Hide();
            this.lblPerimeter.Hide();
        }

        private void frmChangingAreaPerimeter_Load(object sender, EventArgs e)
        {
            // accidentally double clicked
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // accidentally double clicked
        }

        private void mniExit_Click(object sender, EventArgs e)
        {
            // closes the program
            this.Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // declaring local variables
            double length, width, perimeter, area;

            // convert the string from each text box to double
            length = double.Parse(txtLength.Text);
            width = double.Parse(txtWidth.Text);

            // calculate the area and the perimeter
            area = length * width;
            perimeter = length*2 + width*2;

            // insert the area and the perimeter into their respective labels
            this.lblAreaAnswer.Text = Convert.ToString(area) + " Meters^2";
            this.lblPerimeterAnswer.Text = Convert.ToString(perimeter) + " Meters";

            // display the perimerter and the area labels with their respective answers
            this.lblPerimeter.Show();
            this.lblArea.Show();
            this.lblAreaAnswer.Show();
            this.lblPerimeterAnswer.Show();
  
        }
    }
}
