using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lecture_14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            lbxCities.Items.Add(txtNewItem.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbxCities.Items.Add("Aqaba");
        }

        private void btnAddcbxItem_Click(object sender, EventArgs e)
        {
            cbxCountries.Items.Add(txtNewcbxItem.Text);
        }

        private void lbxCities_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lbxCities.SelectedItem!=null)
                txtSelectedListBoxItem.Text = lbxCities.SelectedItem.ToString();
        }

        private void cbxCountries_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSelectedComboBox.Text = cbxCountries.SelectedItem.ToString();
        }

        private void btnDeleteListItem_Click(object sender, EventArgs e)
        {
            lbxCities.Items.Remove(lbxCities.SelectedItem);
        }
    }
}
