using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lecture_15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegiester_Click(object sender, EventArgs e)
        {
            string gender = "";
            string hobbies = "";
            string Employment_Type = "";
            if (rbtnMale.Checked == true)
                gender = "Male";
            else
                gender = "Female";

            if (chkbxCooking.Checked == true)
                hobbies += chkbxCooking.Text;
            if (chbxSwiming.Checked == true)
                hobbies += chbxSwiming.Text;
            if (chkbxGaming.Checked == true)
                hobbies += chkbxGaming.Text;
            if (chkbxReading.Checked == true)
                hobbies += chkbxReading.Text;

            if (rbtnFullTime.Checked == true)
                Employment_Type = "Full Time";
            else
                Employment_Type = "Part Time";

            MessageBox.Show("Gender:" + gender+"\n"+"hobbies:"+hobbies+"\n"+"Emplement Type:"+Employment_Type);
        }
    }
}
