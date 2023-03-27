using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lecture_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClickMe_Click(object sender, EventArgs e)
        {
            //عملنا اوبجيكت من الفورم الجديده
             NeeForm newform = new NeeForm();
             newform.Show();

            //عملنا اوبجيكت من الفورم الاصليه القديمه 
            //Form1 newform = new Form1();
            //newform.Show();
        }
    }
}
