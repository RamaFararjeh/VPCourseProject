using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lecture_16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void mnuNew_Click(object sender, EventArgs e)
        {
            NewForm newform = new NewForm();
            newform.Show();
        }

        private void mnuFont_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
        }

        private void mnuColor_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
        }
    }
}
