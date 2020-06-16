namespace NicroD_IT_Enterprise_Table.Forms
{
    partial class AddingForm
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
            this.SaveButton = new System.Windows.Forms.Button();
            this.DateLabel = new System.Windows.Forms.Label();
            this.DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.OrgTextBox = new System.Windows.Forms.TextBox();
            this.OrgLabel = new System.Windows.Forms.Label();
            this.CityLabel = new System.Windows.Forms.Label();
            this.CityTextBox = new System.Windows.Forms.TextBox();
            this.CountryLabel = new System.Windows.Forms.Label();
            this.CountryTextBox = new System.Windows.Forms.TextBox();
            this.ManagerLabel = new System.Windows.Forms.Label();
            this.ManagerTextBox = new System.Windows.Forms.TextBox();
            this.CountLabel = new System.Windows.Forms.Label();
            this.CountTextBox = new System.Windows.Forms.TextBox();
            this.SumLabel = new System.Windows.Forms.Label();
            this.SumTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // SaveButton
            // 
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.Location = new System.Drawing.Point(614, 12);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(98, 36);
            this.SaveButton.TabIndex = 0;
            this.SaveButton.Text = "Push in DB";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Location = new System.Drawing.Point(17, 13);
            this.DateLabel.Margin = new System.Windows.Forms.Padding(5);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(30, 13);
            this.DateLabel.TabIndex = 1;
            this.DateLabel.Text = "Date";
            // 
            // DateTimePicker
            // 
            this.DateTimePicker.Location = new System.Drawing.Point(14, 28);
            this.DateTimePicker.Margin = new System.Windows.Forms.Padding(5);
            this.DateTimePicker.Name = "DateTimePicker";
            this.DateTimePicker.Size = new System.Drawing.Size(128, 20);
            this.DateTimePicker.TabIndex = 2;
            // 
            // OrgTextBox
            // 
            this.OrgTextBox.Location = new System.Drawing.Point(152, 28);
            this.OrgTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.OrgTextBox.Name = "OrgTextBox";
            this.OrgTextBox.Size = new System.Drawing.Size(100, 20);
            this.OrgTextBox.TabIndex = 3;
            // 
            // OrgLabel
            // 
            this.OrgLabel.AutoSize = true;
            this.OrgLabel.Location = new System.Drawing.Point(155, 12);
            this.OrgLabel.Margin = new System.Windows.Forms.Padding(5);
            this.OrgLabel.Name = "OrgLabel";
            this.OrgLabel.Size = new System.Drawing.Size(66, 13);
            this.OrgLabel.TabIndex = 4;
            this.OrgLabel.Text = "Organisation";
            // 
            // CityLabel
            // 
            this.CityLabel.AutoSize = true;
            this.CityLabel.Location = new System.Drawing.Point(261, 13);
            this.CityLabel.Margin = new System.Windows.Forms.Padding(5);
            this.CityLabel.Name = "CityLabel";
            this.CityLabel.Size = new System.Drawing.Size(24, 13);
            this.CityLabel.TabIndex = 6;
            this.CityLabel.Text = "City";
            // 
            // CityTextBox
            // 
            this.CityTextBox.Location = new System.Drawing.Point(258, 28);
            this.CityTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.CityTextBox.Name = "CityTextBox";
            this.CityTextBox.Size = new System.Drawing.Size(62, 20);
            this.CityTextBox.TabIndex = 5;
            // 
            // CountryLabel
            // 
            this.CountryLabel.AutoSize = true;
            this.CountryLabel.Location = new System.Drawing.Point(330, 13);
            this.CountryLabel.Margin = new System.Windows.Forms.Padding(5);
            this.CountryLabel.Name = "CountryLabel";
            this.CountryLabel.Size = new System.Drawing.Size(43, 13);
            this.CountryLabel.TabIndex = 8;
            this.CountryLabel.Text = "Country";
            // 
            // CountryTextBox
            // 
            this.CountryTextBox.Location = new System.Drawing.Point(326, 28);
            this.CountryTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.CountryTextBox.Name = "CountryTextBox";
            this.CountryTextBox.Size = new System.Drawing.Size(62, 20);
            this.CountryTextBox.TabIndex = 7;
            // 
            // ManagerLabel
            // 
            this.ManagerLabel.AutoSize = true;
            this.ManagerLabel.Location = new System.Drawing.Point(398, 13);
            this.ManagerLabel.Margin = new System.Windows.Forms.Padding(5);
            this.ManagerLabel.Name = "ManagerLabel";
            this.ManagerLabel.Size = new System.Drawing.Size(49, 13);
            this.ManagerLabel.TabIndex = 10;
            this.ManagerLabel.Text = "Manager";
            // 
            // ManagerTextBox
            // 
            this.ManagerTextBox.Location = new System.Drawing.Point(394, 28);
            this.ManagerTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.ManagerTextBox.Name = "ManagerTextBox";
            this.ManagerTextBox.Size = new System.Drawing.Size(100, 20);
            this.ManagerTextBox.TabIndex = 9;
            // 
            // CountLabel
            // 
            this.CountLabel.AutoSize = true;
            this.CountLabel.Location = new System.Drawing.Point(502, 13);
            this.CountLabel.Margin = new System.Windows.Forms.Padding(5);
            this.CountLabel.Name = "CountLabel";
            this.CountLabel.Size = new System.Drawing.Size(35, 13);
            this.CountLabel.TabIndex = 12;
            this.CountLabel.Text = "Count";
            // 
            // CountTextBox
            // 
            this.CountTextBox.Location = new System.Drawing.Point(499, 28);
            this.CountTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.CountTextBox.Name = "CountTextBox";
            this.CountTextBox.Size = new System.Drawing.Size(38, 20);
            this.CountTextBox.TabIndex = 11;
            this.CountTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CountTextBox_KeyPress);
            // 
            // SumLabel
            // 
            this.SumLabel.AutoSize = true;
            this.SumLabel.Location = new System.Drawing.Point(545, 13);
            this.SumLabel.Margin = new System.Windows.Forms.Padding(5);
            this.SumLabel.Name = "SumLabel";
            this.SumLabel.Size = new System.Drawing.Size(28, 13);
            this.SumLabel.TabIndex = 14;
            this.SumLabel.Text = "Sum";
            // 
            // SumTextBox
            // 
            this.SumTextBox.Location = new System.Drawing.Point(542, 28);
            this.SumTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.SumTextBox.Name = "SumTextBox";
            this.SumTextBox.Size = new System.Drawing.Size(38, 20);
            this.SumTextBox.TabIndex = 13;
            this.SumTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SumTextBox_KeyPress);
            // 
            // AddingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(724, 60);
            this.Controls.Add(this.SumLabel);
            this.Controls.Add(this.SumTextBox);
            this.Controls.Add(this.CountLabel);
            this.Controls.Add(this.CountTextBox);
            this.Controls.Add(this.ManagerLabel);
            this.Controls.Add(this.ManagerTextBox);
            this.Controls.Add(this.CountryLabel);
            this.Controls.Add(this.CountryTextBox);
            this.Controls.Add(this.CityLabel);
            this.Controls.Add(this.CityTextBox);
            this.Controls.Add(this.OrgLabel);
            this.Controls.Add(this.OrgTextBox);
            this.Controls.Add(this.DateTimePicker);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.SaveButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AddingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddingForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.DateTimePicker DateTimePicker;
        private System.Windows.Forms.TextBox OrgTextBox;
        private System.Windows.Forms.Label OrgLabel;
        private System.Windows.Forms.Label CityLabel;
        private System.Windows.Forms.TextBox CityTextBox;
        private System.Windows.Forms.Label CountryLabel;
        private System.Windows.Forms.TextBox CountryTextBox;
        private System.Windows.Forms.Label ManagerLabel;
        private System.Windows.Forms.TextBox ManagerTextBox;
        private System.Windows.Forms.Label CountLabel;
        private System.Windows.Forms.TextBox CountTextBox;
        private System.Windows.Forms.Label SumLabel;
        private System.Windows.Forms.TextBox SumTextBox;
    }
}