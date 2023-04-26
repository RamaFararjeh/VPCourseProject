using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lecture_18
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnselectimage_Click(object sender, EventArgs e)
        {
            openFileDialogimages.Filter = "Image files (*.png) | *.png";
            openFileDialogimages.ShowDialog();
            string filename = openFileDialogimages.FileName;
            picbxUser.ImageLocation = filename;
            
        }

        private void btncreatuser_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.Name = txtuser.Text;
            user.DOB = dtpuser.Value;
            user.imagelocation = openFileDialogimages.FileName;
            MessageBox.Show("Name:" + user.Name + "\n" + "DOB:" + user.DOB + "\n" + user.imagelocation);
        }
    }
}
