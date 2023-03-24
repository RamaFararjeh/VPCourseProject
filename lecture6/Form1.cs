using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lecture6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtStudentID.Text = "AE1270";
            cbxCountry.Items.Add("Jordan");
            cbxCountry.Items.Add("Egypt");
            cbxCountry.Items.Add("Syria");

        }
    }
}
