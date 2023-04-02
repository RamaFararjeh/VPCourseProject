using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lecture_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreatControls_Click(object sender, EventArgs e)
        {
            pnlDynamicControls.Controls.Clear();
            int numberOfControls = int.Parse(txtNumberOfControls.Text);
            String typeOfControls = cbxControlType.Text;

            if (typeOfControls == "Button")
            {
                // create loop to create collection of button
                for (int i = 0; i < numberOfControls; i++)
                {
                    // write code to create single button dynamically
                    Button newcontrol = new Button();
                    newcontrol.Name = "btnDynamicButton" + (i + 1);
                    newcontrol.Text = "Dynamic Button" + (i + 1);
                    newcontrol.Size = new Size(100, 40);
                    newcontrol.Location = new Point(0, (i * 50));
                    newcontrol.BackColor = SystemColors.ActiveBorder;
                    pnlDynamicControls.Controls.Add(newcontrol);
                }
            }
            else if (typeOfControls == "TextBox")
            {
                // creat loop to create collection of TextBox
                for (int i = 0; i < numberOfControls; i++)
                {
                    // write code to create single TextBox dynamically
                    TextBox newcontrol = new TextBox();
                    newcontrol.Name = "txtDynamicTextBox " + (i + 1);
                    newcontrol.Text = "Dynamic TextBox " + (i + 1);
                    newcontrol.Size = new Size(100, 40);
                    newcontrol.Location = new Point(0, (i * 30));
                    pnlDynamicControls.Controls.Add(newcontrol);
                }
            }
            else
            {
                // creat loop to create collection of label
                for (int i = 0; i < numberOfControls; i++)
                {
                    // write code to creat single label dynamically
                    Label newcontrol = new Label();
                    newcontrol.Name = "lblDynamiclabel" + (i + 1);
                    newcontrol.Text = "Dynamic label" + (i + 1);
                    newcontrol.Size = new Size(100, 20);
                    newcontrol.Location = new Point(0, (i * 30));
                    pnlDynamicControls.Controls.Add(newcontrol);
                }
            }
            
            
        }

       
    }
}
