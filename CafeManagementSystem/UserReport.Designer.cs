namespace CafeManagementSystem
{
    partial class UserReport
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
            this.button2 = new System.Windows.Forms.Button();
            this.dateToTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dateFromTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.userComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(519, 92);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(169, 31);
            this.button2.TabIndex = 33;
            this.button2.Text = "View";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // dateToTimePicker
            // 
            this.dateToTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateToTimePicker.Location = new System.Drawing.Point(356, 100);
            this.dateToTimePicker.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateToTimePicker.MaxDate = new System.DateTime(2032, 1, 31, 0, 0, 0, 0);
            this.dateToTimePicker.MinDate = new System.DateTime(2024, 11, 1, 0, 0, 0, 0);
            this.dateToTimePicker.Name = "dateToTimePicker";
            this.dateToTimePicker.Size = new System.Drawing.Size(144, 25);
            this.dateToTimePicker.TabIndex = 32;
            this.dateToTimePicker.Value = new System.DateTime(2024, 12, 2, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(299, 103);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 29);
            this.label3.TabIndex = 31;
            this.label3.Text = "To";
            // 
            // dateFromTimePicker
            // 
            this.dateFromTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFromTimePicker.Location = new System.Drawing.Point(133, 103);
            this.dateFromTimePicker.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateFromTimePicker.MaxDate = new System.DateTime(2032, 1, 31, 0, 0, 0, 0);
            this.dateFromTimePicker.MinDate = new System.DateTime(2024, 11, 1, 0, 0, 0, 0);
            this.dateFromTimePicker.Name = "dateFromTimePicker";
            this.dateFromTimePicker.Size = new System.Drawing.Size(144, 25);
            this.dateFromTimePicker.TabIndex = 30;
            this.dateFromTimePicker.Value = new System.DateTime(2024, 11, 1, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 103);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 29);
            this.label2.TabIndex = 29;
            this.label2.Text = "Date : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(267, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 33);
            this.label1.TabIndex = 34;
            this.label1.Text = "User Sell Report";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(44, 55);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 29);
            this.label4.TabIndex = 35;
            this.label4.Text = "Name : ";
            // 
            // userComboBox
            // 
            this.userComboBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userComboBox.FormattingEnabled = true;
            this.userComboBox.Location = new System.Drawing.Point(133, 54);
            this.userComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.userComboBox.Name = "userComboBox";
            this.userComboBox.Size = new System.Drawing.Size(119, 35);
            this.userComboBox.TabIndex = 36;
            this.userComboBox.Text = "-Select-";
            // 
            // UserReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(924, 450);
            this.Controls.Add(this.userComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dateToTimePicker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateFromTimePicker);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("MS UI Gothic", 9F);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserReport";
            this.Load += new System.EventHandler(this.UserReport_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker dateToTimePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateFromTimePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox userComboBox;
    }
}