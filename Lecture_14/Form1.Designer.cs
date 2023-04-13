namespace Lecture_14
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
            this.cbxCountries = new System.Windows.Forms.ComboBox();
            this.lbxCities = new System.Windows.Forms.ListBox();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.txtNewItem = new System.Windows.Forms.TextBox();
            this.txtNewcbxItem = new System.Windows.Forms.TextBox();
            this.btnAddcbxItem = new System.Windows.Forms.Button();
            this.lblSelectedItem = new System.Windows.Forms.Label();
            this.txtSelectedListBoxItem = new System.Windows.Forms.TextBox();
            this.txtSelectedComboBox = new System.Windows.Forms.TextBox();
            this.lblSelectedItemcbx = new System.Windows.Forms.Label();
            this.btnDeleteListItem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbxCountries
            // 
            this.cbxCountries.FormattingEnabled = true;
            this.cbxCountries.Items.AddRange(new object[] {
            "Jordan",
            "Syria",
            "Egypt",
            "UK"});
            this.cbxCountries.Location = new System.Drawing.Point(44, 22);
            this.cbxCountries.Name = "cbxCountries";
            this.cbxCountries.Size = new System.Drawing.Size(188, 21);
            this.cbxCountries.TabIndex = 0;
            this.cbxCountries.SelectedIndexChanged += new System.EventHandler(this.cbxCountries_SelectedIndexChanged);
            // 
            // lbxCities
            // 
            this.lbxCities.FormattingEnabled = true;
            this.lbxCities.Items.AddRange(new object[] {
            "Amman",
            "Damsscus",
            "Cairo",
            "London",
            "Paris"});
            this.lbxCities.Location = new System.Drawing.Point(44, 184);
            this.lbxCities.Name = "lbxCities";
            this.lbxCities.Size = new System.Drawing.Size(188, 199);
            this.lbxCities.TabIndex = 1;
            this.lbxCities.SelectedIndexChanged += new System.EventHandler(this.lbxCities_SelectedIndexChanged);
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(238, 401);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(140, 23);
            this.btnAddItem.TabIndex = 5;
            this.btnAddItem.Text = "Add Item To Listbox";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // txtNewItem
            // 
            this.txtNewItem.Location = new System.Drawing.Point(44, 404);
            this.txtNewItem.Name = "txtNewItem";
            this.txtNewItem.Size = new System.Drawing.Size(188, 20);
            this.txtNewItem.TabIndex = 6;
            // 
            // txtNewcbxItem
            // 
            this.txtNewcbxItem.Location = new System.Drawing.Point(44, 71);
            this.txtNewcbxItem.Name = "txtNewcbxItem";
            this.txtNewcbxItem.Size = new System.Drawing.Size(188, 20);
            this.txtNewcbxItem.TabIndex = 8;
            // 
            // btnAddcbxItem
            // 
            this.btnAddcbxItem.Location = new System.Drawing.Point(238, 68);
            this.btnAddcbxItem.Name = "btnAddcbxItem";
            this.btnAddcbxItem.Size = new System.Drawing.Size(140, 23);
            this.btnAddcbxItem.TabIndex = 7;
            this.btnAddcbxItem.Text = "Add Item To ComboBox";
            this.btnAddcbxItem.UseVisualStyleBackColor = true;
            this.btnAddcbxItem.Click += new System.EventHandler(this.btnAddcbxItem_Click);
            // 
            // lblSelectedItem
            // 
            this.lblSelectedItem.AutoSize = true;
            this.lblSelectedItem.Location = new System.Drawing.Point(469, 154);
            this.lblSelectedItem.Name = "lblSelectedItem";
            this.lblSelectedItem.Size = new System.Drawing.Size(109, 13);
            this.lblSelectedItem.TabIndex = 9;
            this.lblSelectedItem.Text = "Selected ListBox Item";
            // 
            // txtSelectedListBoxItem
            // 
            this.txtSelectedListBoxItem.Location = new System.Drawing.Point(472, 184);
            this.txtSelectedListBoxItem.Name = "txtSelectedListBoxItem";
            this.txtSelectedListBoxItem.Size = new System.Drawing.Size(251, 20);
            this.txtSelectedListBoxItem.TabIndex = 10;
            // 
            // txtSelectedComboBox
            // 
            this.txtSelectedComboBox.Location = new System.Drawing.Point(472, 68);
            this.txtSelectedComboBox.Name = "txtSelectedComboBox";
            this.txtSelectedComboBox.Size = new System.Drawing.Size(251, 20);
            this.txtSelectedComboBox.TabIndex = 12;
            // 
            // lblSelectedItemcbx
            // 
            this.lblSelectedItemcbx.AutoSize = true;
            this.lblSelectedItemcbx.Location = new System.Drawing.Point(469, 43);
            this.lblSelectedItemcbx.Name = "lblSelectedItemcbx";
            this.lblSelectedItemcbx.Size = new System.Drawing.Size(126, 13);
            this.lblSelectedItemcbx.TabIndex = 11;
            this.lblSelectedItemcbx.Text = "Selected ComboBox Item";
            // 
            // btnDeleteListItem
            // 
            this.btnDeleteListItem.BackColor = System.Drawing.Color.Red;
            this.btnDeleteListItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteListItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDeleteListItem.Location = new System.Drawing.Point(479, 264);
            this.btnDeleteListItem.Name = "btnDeleteListItem";
            this.btnDeleteListItem.Size = new System.Drawing.Size(211, 73);
            this.btnDeleteListItem.TabIndex = 13;
            this.btnDeleteListItem.Text = "Delete Item";
            this.btnDeleteListItem.UseVisualStyleBackColor = false;
            this.btnDeleteListItem.Click += new System.EventHandler(this.btnDeleteListItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 448);
            this.Controls.Add(this.btnDeleteListItem);
            this.Controls.Add(this.txtSelectedComboBox);
            this.Controls.Add(this.lblSelectedItemcbx);
            this.Controls.Add(this.txtSelectedListBoxItem);
            this.Controls.Add(this.lblSelectedItem);
            this.Controls.Add(this.txtNewcbxItem);
            this.Controls.Add(this.btnAddcbxItem);
            this.Controls.Add(this.txtNewItem);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.lbxCities);
            this.Controls.Add(this.cbxCountries);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxCountries;
        private System.Windows.Forms.ListBox lbxCities;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.TextBox txtNewItem;
        private System.Windows.Forms.TextBox txtNewcbxItem;
        private System.Windows.Forms.Button btnAddcbxItem;
        private System.Windows.Forms.Label lblSelectedItem;
        private System.Windows.Forms.TextBox txtSelectedListBoxItem;
        private System.Windows.Forms.TextBox txtSelectedComboBox;
        private System.Windows.Forms.Label lblSelectedItemcbx;
        private System.Windows.Forms.Button btnDeleteListItem;
    }
}

