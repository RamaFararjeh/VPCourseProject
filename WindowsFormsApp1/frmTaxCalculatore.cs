﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmTaxCalculatore : Form
    {
        public frmTaxCalculatore()
        {
            InitializeComponent();
        }

        // This Is The Event Handler of The  Button
        private void btnCalculateTax_Click(object sender, EventArgs e)
        {
            try
            {
                int amount = int.Parse(txtAmount.Text);
                double textRate = double.Parse(txtTaxRate.Text);
                double finaltax = amount * textRate;
                txtFianlTax.Text = finaltax.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        
    }
}
