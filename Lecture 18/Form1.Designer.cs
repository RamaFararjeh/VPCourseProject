namespace Lecture_18
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
            this.picbxUser = new System.Windows.Forms.PictureBox();
            this.lblnameuser = new System.Windows.Forms.Label();
            this.lblDOB = new System.Windows.Forms.Label();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.dtpuser = new System.Windows.Forms.DateTimePicker();
            this.btncreatuser = new System.Windows.Forms.Button();
            this.btnselectimage = new System.Windows.Forms.Button();
            this.openFileDialogimages = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.picbxUser)).BeginInit();
            this.SuspendLayout();
            // 
            // picbxUser
            // 
            this.picbxUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picbxUser.Location = new System.Drawing.Point(12, 12);
            this.picbxUser.Name = "picbxUser";
            this.picbxUser.Size = new System.Drawing.Size(123, 158);
            this.picbxUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbxUser.TabIndex = 0;
            this.picbxUser.TabStop = false;
            // 
            // lblnameuser
            // 
            this.lblnameuser.AutoSize = true;
            this.lblnameuser.Font = new System.Drawing.Font("NSimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnameuser.Location = new System.Drawing.Point(161, 44);
            this.lblnameuser.Name = "lblnameuser";
            this.lblnameuser.Size = new System.Drawing.Size(79, 16);
            this.lblnameuser.TabIndex = 1;
            this.lblnameuser.Text = "User Name";
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Font = new System.Drawing.Font("NSimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDOB.Location = new System.Drawing.Point(186, 81);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(31, 16);
            this.lblDOB.TabIndex = 2;
            this.lblDOB.Text = "DOB";
            // 
            // txtuser
            // 
            this.txtuser.Font = new System.Drawing.Font("NSimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtuser.Location = new System.Drawing.Point(246, 41);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(214, 26);
            this.txtuser.TabIndex = 3;
            // 
            // dtpuser
            // 
            this.dtpuser.Font = new System.Drawing.Font("NSimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpuser.Location = new System.Drawing.Point(246, 74);
            this.dtpuser.Name = "dtpuser";
            this.dtpuser.Size = new System.Drawing.Size(214, 26);
            this.dtpuser.TabIndex = 4;
            // 
            // btncreatuser
            // 
            this.btncreatuser.Font = new System.Drawing.Font("NSimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncreatuser.Location = new System.Drawing.Point(300, 115);
            this.btncreatuser.Name = "btncreatuser";
            this.btncreatuser.Size = new System.Drawing.Size(103, 41);
            this.btncreatuser.TabIndex = 5;
            this.btncreatuser.Text = "creat user";
            this.btncreatuser.UseVisualStyleBackColor = true;
            this.btncreatuser.Click += new System.EventHandler(this.btncreatuser_Click);
            // 
            // btnselectimage
            // 
            this.btnselectimage.Font = new System.Drawing.Font("NSimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnselectimage.Location = new System.Drawing.Point(12, 176);
            this.btnselectimage.Name = "btnselectimage";
            this.btnselectimage.Size = new System.Drawing.Size(123, 28);
            this.btnselectimage.TabIndex = 6;
            this.btnselectimage.Text = "select image";
            this.btnselectimage.UseVisualStyleBackColor = true;
            this.btnselectimage.Click += new System.EventHandler(this.btnselectimage_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 216);
            this.Controls.Add(this.btnselectimage);
            this.Controls.Add(this.btncreatuser);
            this.Controls.Add(this.dtpuser);
            this.Controls.Add(this.txtuser);
            this.Controls.Add(this.lblDOB);
            this.Controls.Add(this.lblnameuser);
            this.Controls.Add(this.picbxUser);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picbxUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picbxUser;
        private System.Windows.Forms.Label lblnameuser;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.DateTimePicker dtpuser;
        private System.Windows.Forms.Button btncreatuser;
        private System.Windows.Forms.Button btnselectimage;
        private System.Windows.Forms.OpenFileDialog openFileDialogimages;
    }
}

