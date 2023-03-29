namespace WindowsFormsApp1
{
    partial class frmTaxCalculatore
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
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblTaxRate = new System.Windows.Forms.Label();
            this.lblFinalTax = new System.Windows.Forms.Label();
            this.btnCalculateTax = new System.Windows.Forms.Button();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtTaxRate = new System.Windows.Forms.TextBox();
            this.txtFianlTax = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(75, 34);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(65, 20);
            this.lblAmount.TabIndex = 0;
            this.lblAmount.Text = "Amount";
            // 
            // lblTaxRate
            // 
            this.lblTaxRate.AutoSize = true;
            this.lblTaxRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaxRate.Location = new System.Drawing.Point(71, 102);
            this.lblTaxRate.Name = "lblTaxRate";
            this.lblTaxRate.Size = new System.Drawing.Size(73, 20);
            this.lblTaxRate.TabIndex = 1;
            this.lblTaxRate.Text = "Tax Rate";
            // 
            // lblFinalTax
            // 
            this.lblFinalTax.AutoSize = true;
            this.lblFinalTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinalTax.Location = new System.Drawing.Point(71, 232);
            this.lblFinalTax.Name = "lblFinalTax";
            this.lblFinalTax.Size = new System.Drawing.Size(72, 20);
            this.lblFinalTax.TabIndex = 2;
            this.lblFinalTax.Text = "Final Tax";
            // 
            // btnCalculateTax
            // 
            this.btnCalculateTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculateTax.Location = new System.Drawing.Point(187, 148);
            this.btnCalculateTax.Name = "btnCalculateTax";
            this.btnCalculateTax.Size = new System.Drawing.Size(130, 37);
            this.btnCalculateTax.TabIndex = 4;
            this.btnCalculateTax.Text = "Calculate Tax";
            this.btnCalculateTax.UseVisualStyleBackColor = true;
            this.btnCalculateTax.Click += new System.EventHandler(this.btnCalculateTax_Click);
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.Location = new System.Drawing.Point(148, 34);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(209, 26);
            this.txtAmount.TabIndex = 1;
            // 
            // txtTaxRate
            // 
            this.txtTaxRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaxRate.Location = new System.Drawing.Point(148, 95);
            this.txtTaxRate.Name = "txtTaxRate";
            this.txtTaxRate.Size = new System.Drawing.Size(209, 26);
            this.txtTaxRate.TabIndex = 2;
            // 
            // txtFianlTax
            // 
            this.txtFianlTax.Enabled = false;
            this.txtFianlTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFianlTax.Location = new System.Drawing.Point(148, 225);
            this.txtFianlTax.Name = "txtFianlTax";
            this.txtFianlTax.Size = new System.Drawing.Size(209, 26);
            this.txtFianlTax.TabIndex = 5;
            // 
            // frmTaxCalculatore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(452, 321);
            this.Controls.Add(this.txtFianlTax);
            this.Controls.Add(this.txtTaxRate);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.btnCalculateTax);
            this.Controls.Add(this.lblFinalTax);
            this.Controls.Add(this.lblTaxRate);
            this.Controls.Add(this.lblAmount);
            this.Name = "frmTaxCalculatore";
            this.Text = "Tax Calculater";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblTaxRate;
        private System.Windows.Forms.Label lblFinalTax;
        private System.Windows.Forms.Button btnCalculateTax;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtTaxRate;
        private System.Windows.Forms.TextBox txtFianlTax;
    }
}

