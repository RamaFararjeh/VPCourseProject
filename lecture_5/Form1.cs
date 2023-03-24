using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lecture_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPrintHello_Click(object sender, EventArgs e)
        {
            // This Is An Event Handler For The Click Event
            string myName = txtName.Text;
            MessageBox.Show("Welcom "+myName+" :')");
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            // This Is An Event Handler Which Is Fired Whenever Aletter Is Typed Inside txtName
            lblLetterCount.Text = txtName.Text.Length.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
