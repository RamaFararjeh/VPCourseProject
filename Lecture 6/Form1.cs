using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lecture_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*txtID.Text = "AE1270";*/
            cbxContries.Items.Add("Jordan");
            cbxContries.Items.Add("Egypt");
            cbxContries.Items.Add("UK");
            dtpDateOfBirth.Value = DateTime.Now.AddYears(-20);
            txtID.Focus();

        }
    }
}
