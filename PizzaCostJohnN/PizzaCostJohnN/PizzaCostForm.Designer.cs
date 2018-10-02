namespace PizzaCostJohnN
{
    partial class frmPizzaCost
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
            this.nudDiameter = new System.Windows.Forms.NumericUpDown();
            this.lblDiameter = new System.Windows.Forms.Label();
            this.lblNumberOfPizzas = new System.Windows.Forms.Label();
            this.txtNumberOfPizzas = new System.Windows.Forms.TextBox();
            this.btnPrice = new System.Windows.Forms.Button();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblHST = new System.Windows.Forms.Label();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.lblHSTAnswer = new System.Windows.Forms.Label();
            this.lblSubtotalAnswer = new System.Windows.Forms.Label();
            this.lblTotalCostAnswer = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiameter)).BeginInit();
            this.SuspendLayout();
            // 
            // nudDiameter
            // 
            this.nudDiameter.Location = new System.Drawing.Point(463, 88);
            this.nudDiameter.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nudDiameter.Minimum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.nudDiameter.Name = "nudDiameter";
            this.nudDiameter.Size = new System.Drawing.Size(120, 20);
            this.nudDiameter.TabIndex = 0;
            this.nudDiameter.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // lblDiameter
            // 
            this.lblDiameter.AutoSize = true;
            this.lblDiameter.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiameter.Location = new System.Drawing.Point(33, 82);
            this.lblDiameter.Name = "lblDiameter";
            this.lblDiameter.Size = new System.Drawing.Size(411, 28);
            this.lblDiameter.TabIndex = 2;
            this.lblDiameter.Text = "Enter the diameter of the pizza you want";
            // 
            // lblNumberOfPizzas
            // 
            this.lblNumberOfPizzas.AutoSize = true;
            this.lblNumberOfPizzas.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfPizzas.Location = new System.Drawing.Point(33, 135);
            this.lblNumberOfPizzas.Name = "lblNumberOfPizzas";
            this.lblNumberOfPizzas.Size = new System.Drawing.Size(348, 28);
            this.lblNumberOfPizzas.TabIndex = 3;
            this.lblNumberOfPizzas.Text = "Enter the amount pizzas you want";
            // 
            // txtNumberOfPizzas
            // 
            this.txtNumberOfPizzas.Location = new System.Drawing.Point(463, 143);
            this.txtNumberOfPizzas.Name = "txtNumberOfPizzas";
            this.txtNumberOfPizzas.Size = new System.Drawing.Size(120, 20);
            this.txtNumberOfPizzas.TabIndex = 4;
            // 
            // btnPrice
            // 
            this.btnPrice.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrice.Location = new System.Drawing.Point(668, 107);
            this.btnPrice.Name = "btnPrice";
            this.btnPrice.Size = new System.Drawing.Size(75, 35);
            this.btnPrice.TabIndex = 5;
            this.btnPrice.Text = "Price";
            this.btnPrice.UseVisualStyleBackColor = true;
            this.btnPrice.Click += new System.EventHandler(this.btnPrice_Click);
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotal.Location = new System.Drawing.Point(201, 225);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(113, 32);
            this.lblSubtotal.TabIndex = 6;
            this.lblSubtotal.Text = "Subtotal:";
            // 
            // lblHST
            // 
            this.lblHST.AutoSize = true;
            this.lblHST.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHST.Location = new System.Drawing.Point(241, 274);
            this.lblHST.Name = "lblHST";
            this.lblHST.Size = new System.Drawing.Size(72, 32);
            this.lblHST.TabIndex = 7;
            this.lblHST.Text = "HST:";
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.AutoSize = true;
            this.lblTotalCost.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCost.Location = new System.Drawing.Point(187, 357);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(126, 32);
            this.lblTotalCost.TabIndex = 8;
            this.lblTotalCost.Text = "TotalCost:";
            // 
            // lblHSTAnswer
            // 
            this.lblHSTAnswer.AutoSize = true;
            this.lblHSTAnswer.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHSTAnswer.Location = new System.Drawing.Point(315, 278);
            this.lblHSTAnswer.Name = "lblHSTAnswer";
            this.lblHSTAnswer.Size = new System.Drawing.Size(23, 28);
            this.lblHSTAnswer.TabIndex = 9;
            this.lblHSTAnswer.Text = "$";
            // 
            // lblSubtotalAnswer
            // 
            this.lblSubtotalAnswer.AutoSize = true;
            this.lblSubtotalAnswer.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotalAnswer.Location = new System.Drawing.Point(315, 225);
            this.lblSubtotalAnswer.Name = "lblSubtotalAnswer";
            this.lblSubtotalAnswer.Size = new System.Drawing.Size(23, 28);
            this.lblSubtotalAnswer.TabIndex = 10;
            this.lblSubtotalAnswer.Text = "$";
            // 
            // lblTotalCostAnswer
            // 
            this.lblTotalCostAnswer.AutoSize = true;
            this.lblTotalCostAnswer.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCostAnswer.Location = new System.Drawing.Point(315, 360);
            this.lblTotalCostAnswer.Name = "lblTotalCostAnswer";
            this.lblTotalCostAnswer.Size = new System.Drawing.Size(23, 28);
            this.lblTotalCostAnswer.TabIndex = 11;
            this.lblTotalCostAnswer.Text = "$";
            // 
            // frmPizzaCost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.ClientSize = new System.Drawing.Size(839, 466);
            this.Controls.Add(this.lblTotalCostAnswer);
            this.Controls.Add(this.lblSubtotalAnswer);
            this.Controls.Add(this.lblHSTAnswer);
            this.Controls.Add(this.lblTotalCost);
            this.Controls.Add(this.lblHST);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.btnPrice);
            this.Controls.Add(this.txtNumberOfPizzas);
            this.Controls.Add(this.lblNumberOfPizzas);
            this.Controls.Add(this.lblDiameter);
            this.Controls.Add(this.nudDiameter);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "frmPizzaCost";
            this.Text = "Pizza Cost";
            ((System.ComponentModel.ISupportInitialize)(this.nudDiameter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudDiameter;
        private System.Windows.Forms.Label lblDiameter;
        private System.Windows.Forms.Label lblNumberOfPizzas;
        private System.Windows.Forms.TextBox txtNumberOfPizzas;
        private System.Windows.Forms.Button btnPrice;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblHST;
        private System.Windows.Forms.Label lblTotalCost;
        private System.Windows.Forms.Label lblHSTAnswer;
        private System.Windows.Forms.Label lblSubtotalAnswer;
        private System.Windows.Forms.Label lblTotalCostAnswer;
    }
}

