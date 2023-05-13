namespace Midterm_2023
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
            this.lblUS = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.txtUS = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblUS
            // 
            this.lblUS.AutoSize = true;
            this.lblUS.Location = new System.Drawing.Point(38, 94);
            this.lblUS.Name = "lblUS";
            this.lblUS.Size = new System.Drawing.Size(53, 13);
            this.lblUS.TabIndex = 0;
            this.lblUS.Text = "username";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Location = new System.Drawing.Point(38, 149);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(52, 13);
            this.lblPass.TabIndex = 1;
            this.lblPass.Text = "password";
            // 
            // txtUS
            // 
            this.txtUS.Location = new System.Drawing.Point(97, 91);
            this.txtUS.Name = "txtUS";
            this.txtUS.Size = new System.Drawing.Size(100, 20);
            this.txtUS.TabIndex = 2;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(96, 148);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(100, 20);
            this.txtPass.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(569, 397);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUS);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.lblUS);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUS;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.TextBox txtUS;
        private System.Windows.Forms.TextBox txtPass;
    }
}

