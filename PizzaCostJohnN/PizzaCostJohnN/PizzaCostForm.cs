/*
 * Created by: John Ngundeng
 * Created on: october 2, 2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #12 - Pizza cost
 * This program Calculates the subcost, tax and totalcost 
 * of pizzas at various diameteres and numbers
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

namespace PizzaCostJohnN
{
    public partial class frmPizzaCost : Form
    {
        public frmPizzaCost()
        {
            InitializeComponent();
            // HIding the labels at the start
            this.lblSubtotal.Hide();
            this.lblSubtotalAnswer.Hide();
            this.lblHST.Hide();
            this.lblHSTAnswer.Hide();
            this.lblTotalCost.Hide();
            this.lblTotalCostAnswer.Hide();
        }

        private void btnPrice_Click(object sender, EventArgs e)
        {
            // Declaring local variables
            double diameter, numberOfPizzas, HST, Subtotal, TotalCost;

            // convert the string in the text box to double
            numberOfPizzas = double.Parse(txtNumberOfPizzas.Text);
            
            // convert the numeric up down box value to double
             diameter = (double)(nudDiameter.Value);

            // Calculate the price of the pizza
            Subtotal = (diameter * 0.50 + 0.99 + 0.75) * numberOfPizzas;
            HST = Subtotal * 0.13;
            TotalCost = Subtotal + HST;
            
            // Rounds the numbers to 2 decimal places
            HST = Convert.ToDouble(String.Format("{0:0.00}", HST));
            Subtotal = Convert.ToDouble(String.Format("{0:0.00}", Subtotal));
            TotalCost = Convert.ToDouble(String.Format("{0:0.00}", TotalCost));

            // insert the pricdes into their respective labels 
            this.lblHSTAnswer.Text = "$"+ Convert.ToString(HST);
            this.lblSubtotalAnswer.Text = "$"+ Convert.ToString(Subtotal);
            this.lblTotalCostAnswer.Text = "$"+ Convert.ToString(TotalCost);

            // showing the labels 
            this.lblSubtotal.Show();
            this.lblSubtotalAnswer.Show();
            this.lblHST.Show();
            this.lblHSTAnswer.Show();
            this.lblTotalCost.Show();
            this.lblTotalCostAnswer.Show();

        }
    }
}
