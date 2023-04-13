namespace Lecture_15
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
            this.rbtnMale = new System.Windows.Forms.RadioButton();
            this.rbtnFemale = new System.Windows.Forms.RadioButton();
            this.chbxSwiming = new System.Windows.Forms.CheckBox();
            this.chkbxReading = new System.Windows.Forms.CheckBox();
            this.chkbxCooking = new System.Windows.Forms.CheckBox();
            this.chkbxGaming = new System.Windows.Forms.CheckBox();
            this.btnRegiester = new System.Windows.Forms.Button();
            this.rbtnFullTime = new System.Windows.Forms.RadioButton();
            this.rbtnPartTime = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbtnMale
            // 
            this.rbtnMale.AutoSize = true;
            this.rbtnMale.Location = new System.Drawing.Point(17, 58);
            this.rbtnMale.Name = "rbtnMale";
            this.rbtnMale.Size = new System.Drawing.Size(67, 23);
            this.rbtnMale.TabIndex = 2;
            this.rbtnMale.TabStop = true;
            this.rbtnMale.Text = "Male";
            this.rbtnMale.UseVisualStyleBackColor = true;
            // 
            // rbtnFemale
            // 
            this.rbtnFemale.AutoSize = true;
            this.rbtnFemale.Location = new System.Drawing.Point(96, 58);
            this.rbtnFemale.Name = "rbtnFemale";
            this.rbtnFemale.Size = new System.Drawing.Size(87, 23);
            this.rbtnFemale.TabIndex = 3;
            this.rbtnFemale.TabStop = true;
            this.rbtnFemale.Text = "Female";
            this.rbtnFemale.UseVisualStyleBackColor = true;
            // 
            // chbxSwiming
            // 
            this.chbxSwiming.AutoSize = true;
            this.chbxSwiming.Location = new System.Drawing.Point(31, 38);
            this.chbxSwiming.Name = "chbxSwiming";
            this.chbxSwiming.Size = new System.Drawing.Size(108, 23);
            this.chbxSwiming.TabIndex = 4;
            this.chbxSwiming.Text = "swimming";
            this.chbxSwiming.UseVisualStyleBackColor = true;
            // 
            // chkbxReading
            // 
            this.chkbxReading.AutoSize = true;
            this.chkbxReading.Location = new System.Drawing.Point(31, 61);
            this.chkbxReading.Name = "chkbxReading";
            this.chkbxReading.Size = new System.Drawing.Size(98, 23);
            this.chkbxReading.TabIndex = 5;
            this.chkbxReading.Text = "Reading";
            this.chkbxReading.UseVisualStyleBackColor = true;
            // 
            // chkbxCooking
            // 
            this.chkbxCooking.AutoSize = true;
            this.chkbxCooking.Location = new System.Drawing.Point(31, 105);
            this.chkbxCooking.Name = "chkbxCooking";
            this.chkbxCooking.Size = new System.Drawing.Size(98, 23);
            this.chkbxCooking.TabIndex = 7;
            this.chkbxCooking.Text = "Cooking";
            this.chkbxCooking.UseVisualStyleBackColor = true;
            // 
            // chkbxGaming
            // 
            this.chkbxGaming.AutoSize = true;
            this.chkbxGaming.Location = new System.Drawing.Point(31, 82);
            this.chkbxGaming.Name = "chkbxGaming";
            this.chkbxGaming.Size = new System.Drawing.Size(88, 23);
            this.chkbxGaming.TabIndex = 6;
            this.chkbxGaming.Text = "Gaming";
            this.chkbxGaming.UseVisualStyleBackColor = true;
            // 
            // btnRegiester
            // 
            this.btnRegiester.Location = new System.Drawing.Point(311, 314);
            this.btnRegiester.Name = "btnRegiester";
            this.btnRegiester.Size = new System.Drawing.Size(137, 48);
            this.btnRegiester.TabIndex = 8;
            this.btnRegiester.Text = "Register";
            this.btnRegiester.UseVisualStyleBackColor = true;
            this.btnRegiester.Click += new System.EventHandler(this.btnRegiester_Click);
            // 
            // rbtnFullTime
            // 
            this.rbtnFullTime.AutoSize = true;
            this.rbtnFullTime.Location = new System.Drawing.Point(43, 64);
            this.rbtnFullTime.Name = "rbtnFullTime";
            this.rbtnFullTime.Size = new System.Drawing.Size(117, 23);
            this.rbtnFullTime.TabIndex = 10;
            this.rbtnFullTime.TabStop = true;
            this.rbtnFullTime.Text = "Full-Time";
            this.rbtnFullTime.UseVisualStyleBackColor = true;
            // 
            // rbtnPartTime
            // 
            this.rbtnPartTime.AutoSize = true;
            this.rbtnPartTime.Location = new System.Drawing.Point(43, 93);
            this.rbtnPartTime.Name = "rbtnPartTime";
            this.rbtnPartTime.Size = new System.Drawing.Size(117, 23);
            this.rbtnPartTime.TabIndex = 11;
            this.rbtnPartTime.TabStop = true;
            this.rbtnPartTime.Text = "Part-Time";
            this.rbtnPartTime.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkbxReading);
            this.groupBox1.Controls.Add(this.chbxSwiming);
            this.groupBox1.Controls.Add(this.chkbxGaming);
            this.groupBox1.Controls.Add(this.chkbxCooking);
            this.groupBox1.Location = new System.Drawing.Point(280, 105);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 170);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hobbies";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbtnFemale);
            this.groupBox2.Controls.Add(this.rbtnMale);
            this.groupBox2.Location = new System.Drawing.Point(41, 131);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 130);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Gender";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbtnPartTime);
            this.groupBox3.Controls.Add(this.rbtnFullTime);
            this.groupBox3.Location = new System.Drawing.Point(524, 105);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 170);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Employment Type";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(747, 422);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnRegiester);
            this.Font = new System.Drawing.Font("NSimSun", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RadioButton rbtnMale;
        private System.Windows.Forms.RadioButton rbtnFemale;
        private System.Windows.Forms.CheckBox chbxSwiming;
        private System.Windows.Forms.CheckBox chkbxReading;
        private System.Windows.Forms.CheckBox chkbxCooking;
        private System.Windows.Forms.CheckBox chkbxGaming;
        private System.Windows.Forms.Button btnRegiester;
        private System.Windows.Forms.RadioButton rbtnFullTime;
        private System.Windows.Forms.RadioButton rbtnPartTime;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

