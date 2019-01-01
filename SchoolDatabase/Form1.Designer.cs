namespace SchoolDatabase

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
            this.Xbutton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.lnameBox = new System.Windows.Forms.TextBox();
            this.fnameBox = new System.Windows.Forms.TextBox();
            this.delButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.schoolBox = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Xbutton
            // 
            this.Xbutton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Xbutton.Location = new System.Drawing.Point(353, 9);
            this.Xbutton.Margin = new System.Windows.Forms.Padding(2);
            this.Xbutton.Name = "Xbutton";
            this.Xbutton.Size = new System.Drawing.Size(29, 22);
            this.Xbutton.TabIndex = 15;
            this.Xbutton.Text = "X";
            this.Xbutton.UseVisualStyleBackColor = true;
            this.Xbutton.Click += new System.EventHandler(this.Xbutton_Click_1);
            // 
            // editButton
            // 
            this.editButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.editButton.Location = new System.Drawing.Point(247, 8);
            this.editButton.Margin = new System.Windows.Forms.Padding(2);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(94, 23);
            this.editButton.TabIndex = 14;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click_1);
            // 
            // lnameBox
            // 
            this.lnameBox.Location = new System.Drawing.Point(134, 35);
            this.lnameBox.Margin = new System.Windows.Forms.Padding(2);
            this.lnameBox.Name = "lnameBox";
            this.lnameBox.Size = new System.Drawing.Size(105, 20);
            this.lnameBox.TabIndex = 13;
            this.lnameBox.TextChanged += new System.EventHandler(this.lnameBox_TextChanged_1);
            // 
            // fnameBox
            // 
            this.fnameBox.Location = new System.Drawing.Point(11, 35);
            this.fnameBox.Margin = new System.Windows.Forms.Padding(2);
            this.fnameBox.Name = "fnameBox";
            this.fnameBox.Size = new System.Drawing.Size(114, 20);
            this.fnameBox.TabIndex = 12;
            this.fnameBox.TextChanged += new System.EventHandler(this.fnameBox_TextChanged_1);
            // 
            // delButton
            // 
            this.delButton.Location = new System.Drawing.Point(134, 8);
            this.delButton.Margin = new System.Windows.Forms.Padding(2);
            this.delButton.Name = "delButton";
            this.delButton.Size = new System.Drawing.Size(94, 23);
            this.delButton.TabIndex = 11;
            this.delButton.Text = "Delete";
            this.delButton.UseVisualStyleBackColor = true;
            this.delButton.Click += new System.EventHandler(this.delButton_Click_1);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(11, 8);
            this.addButton.Margin = new System.Windows.Forms.Padding(2);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(94, 23);
            this.addButton.TabIndex = 10;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click_1);
            // 
            // schoolBox
            // 
            this.schoolBox.FormattingEnabled = true;
            this.schoolBox.Location = new System.Drawing.Point(247, 35);
            this.schoolBox.Margin = new System.Windows.Forms.Padding(2);
            this.schoolBox.Name = "schoolBox";
            this.schoolBox.Size = new System.Drawing.Size(135, 21);
            this.schoolBox.TabIndex = 9;
            this.schoolBox.SelectedIndexChanged += new System.EventHandler(this.schoolBox_SelectedIndexChanged_1);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(11, 62);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(371, 173);
            this.listBox1.TabIndex = 8;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            this.listBox1.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.listBox1_Format_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 240);
            this.Controls.Add(this.Xbutton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.lnameBox);
            this.Controls.Add(this.fnameBox);
            this.Controls.Add(this.delButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.schoolBox);
            this.Controls.Add(this.listBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "SchoolDatabase";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Xbutton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.TextBox lnameBox;
        private System.Windows.Forms.TextBox fnameBox;
        private System.Windows.Forms.Button delButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.ComboBox schoolBox;
        private System.Windows.Forms.ListBox listBox1;
    }
}

