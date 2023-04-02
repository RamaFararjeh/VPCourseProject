namespace Lecture_10
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
            this.btnCreatControls = new System.Windows.Forms.Button();
            this.lblNumberOfControls = new System.Windows.Forms.Label();
            this.txtNumberOfControls = new System.Windows.Forms.TextBox();
            this.pnlDynamicControls = new System.Windows.Forms.Panel();
            this.cbxControlType = new System.Windows.Forms.ComboBox();
            this.lblControlType = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCreatControls
            // 
            this.btnCreatControls.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnCreatControls.Location = new System.Drawing.Point(161, 102);
            this.btnCreatControls.Name = "btnCreatControls";
            this.btnCreatControls.Size = new System.Drawing.Size(130, 39);
            this.btnCreatControls.TabIndex = 0;
            this.btnCreatControls.Text = "Creat Controls";
            this.btnCreatControls.UseVisualStyleBackColor = false;
            this.btnCreatControls.Click += new System.EventHandler(this.btnCreatControls_Click);
            // 
            // lblNumberOfControls
            // 
            this.lblNumberOfControls.AutoSize = true;
            this.lblNumberOfControls.BackColor = System.Drawing.Color.Gold;
            this.lblNumberOfControls.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNumberOfControls.Location = new System.Drawing.Point(16, 76);
            this.lblNumberOfControls.Name = "lblNumberOfControls";
            this.lblNumberOfControls.Size = new System.Drawing.Size(101, 15);
            this.lblNumberOfControls.TabIndex = 1;
            this.lblNumberOfControls.Text = "Number Of Controls";
            // 
            // txtNumberOfControls
            // 
            this.txtNumberOfControls.Location = new System.Drawing.Point(123, 76);
            this.txtNumberOfControls.Name = "txtNumberOfControls";
            this.txtNumberOfControls.Size = new System.Drawing.Size(220, 20);
            this.txtNumberOfControls.TabIndex = 2;
            // 
            // pnlDynamicControls
            // 
            this.pnlDynamicControls.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDynamicControls.Location = new System.Drawing.Point(123, 156);
            this.pnlDynamicControls.Name = "pnlDynamicControls";
            this.pnlDynamicControls.Size = new System.Drawing.Size(200, 384);
            this.pnlDynamicControls.TabIndex = 3;
            // 
            // cbxControlType
            // 
            this.cbxControlType.FormattingEnabled = true;
            this.cbxControlType.Items.AddRange(new object[] {
            "Button",
            "TextBox",
            "Label"});
            this.cbxControlType.Location = new System.Drawing.Point(123, 39);
            this.cbxControlType.Name = "cbxControlType";
            this.cbxControlType.Size = new System.Drawing.Size(220, 21);
            this.cbxControlType.TabIndex = 4;
            // 
            // lblControlType
            // 
            this.lblControlType.AutoSize = true;
            this.lblControlType.BackColor = System.Drawing.Color.Gold;
            this.lblControlType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblControlType.Location = new System.Drawing.Point(47, 45);
            this.lblControlType.Name = "lblControlType";
            this.lblControlType.Size = new System.Drawing.Size(69, 15);
            this.lblControlType.TabIndex = 5;
            this.lblControlType.Text = "Control Type";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(397, 552);
            this.Controls.Add(this.lblControlType);
            this.Controls.Add(this.cbxControlType);
            this.Controls.Add(this.pnlDynamicControls);
            this.Controls.Add(this.txtNumberOfControls);
            this.Controls.Add(this.lblNumberOfControls);
            this.Controls.Add(this.btnCreatControls);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreatControls;
        private System.Windows.Forms.Label lblNumberOfControls;
        private System.Windows.Forms.TextBox txtNumberOfControls;
        private System.Windows.Forms.Panel pnlDynamicControls;
        private System.Windows.Forms.ComboBox cbxControlType;
        private System.Windows.Forms.Label lblControlType;
    }
}

