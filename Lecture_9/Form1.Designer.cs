namespace Lecture_9
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblID = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.txtEmplyeeID = new System.Windows.Forms.TextBox();
            this.txtEmployeeName = new System.Windows.Forms.TextBox();
            this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.btnCreatEmplyee = new System.Windows.Forms.Button();
            this.btnCreatTextBox = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(75, 75);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(61, 13);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "Emplyee ID";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(52, 153);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(84, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Employee Name";
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.AutoSize = true;
            this.lblDateOfBirth.Location = new System.Drawing.Point(106, 232);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(30, 13);
            this.lblDateOfBirth.TabIndex = 2;
            this.lblDateOfBirth.Text = "DOB";
            // 
            // txtEmplyeeID
            // 
            this.txtEmplyeeID.Location = new System.Drawing.Point(142, 68);
            this.txtEmplyeeID.Name = "txtEmplyeeID";
            this.txtEmplyeeID.Size = new System.Drawing.Size(134, 20);
            this.txtEmplyeeID.TabIndex = 3;
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.Location = new System.Drawing.Point(142, 146);
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.Size = new System.Drawing.Size(228, 20);
            this.txtEmployeeName.TabIndex = 4;
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.Location = new System.Drawing.Point(142, 225);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(200, 20);
            this.dtpDateOfBirth.TabIndex = 5;
            // 
            // btnCreatEmplyee
            // 
            this.btnCreatEmplyee.BackColor = System.Drawing.Color.PeachPuff;
            this.btnCreatEmplyee.ForeColor = System.Drawing.Color.Red;
            this.btnCreatEmplyee.Location = new System.Drawing.Point(190, 286);
            this.btnCreatEmplyee.Name = "btnCreatEmplyee";
            this.btnCreatEmplyee.Size = new System.Drawing.Size(114, 50);
            this.btnCreatEmplyee.TabIndex = 6;
            this.btnCreatEmplyee.Text = "Creat Employee";
            this.btnCreatEmplyee.UseVisualStyleBackColor = false;
            this.btnCreatEmplyee.Click += new System.EventHandler(this.btnCreatEmplyee_Click);
            // 
            // btnCreatTextBox
            // 
            this.btnCreatTextBox.Location = new System.Drawing.Point(190, 370);
            this.btnCreatTextBox.Name = "btnCreatTextBox";
            this.btnCreatTextBox.Size = new System.Drawing.Size(131, 23);
            this.btnCreatTextBox.TabIndex = 7;
            this.btnCreatTextBox.Text = "Creat TextBox";
            this.btnCreatTextBox.UseVisualStyleBackColor = true;
            this.btnCreatTextBox.Click += new System.EventHandler(this.btnCreatTextBox_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(12, 275);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(151, 165);
            this.panel1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(470, 452);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCreatTextBox);
            this.Controls.Add(this.btnCreatEmplyee);
            this.Controls.Add(this.dtpDateOfBirth);
            this.Controls.Add(this.txtEmployeeName);
            this.Controls.Add(this.txtEmplyeeID);
            this.Controls.Add(this.lblDateOfBirth);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblID);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDateOfBirth;
        private System.Windows.Forms.TextBox txtEmplyeeID;
        private System.Windows.Forms.TextBox txtEmployeeName;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
        private System.Windows.Forms.Button btnCreatEmplyee;
        private System.Windows.Forms.Button btnCreatTextBox;
        private System.Windows.Forms.Panel panel1;
    }
}

