using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lecture_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreatEmplyee_Click(object sender, EventArgs e)
        {
            Emplyee newEmployee = new Emplyee(int.Parse(txtEmplyeeID.Text), txtEmployeeName.Text, dtpDateOfBirth.Value);
            newEmployee.Id = int.Parse(txtEmplyeeID.Text);
            newEmployee.Name = txtEmployeeName.Text;
            newEmployee.DateOfBirth = dtpDateOfBirth.Value;
            MessageBox.Show("Emplyee ID :" + newEmployee.Id.ToString()+"\n"+
                "Emplyee Name:"+newEmployee.Name +"\n"+
                "Emplyee Date Of Birth :"+newEmployee.DateOfBirth.ToShortDateString());
        }

        private void btnCreatTextBox_Click(object sender, EventArgs e)
        {
            TextBox newtextbox = new TextBox();
            newtextbox.Name = "txtTextBox";
            newtextbox.Text = "Dynamic textBox";
            newtextbox.Location = new Point(0, 0);
            newtextbox.Size = new Size(100, 40);
            panel1.Controls.Add(newtextbox);
        }
    }
}
