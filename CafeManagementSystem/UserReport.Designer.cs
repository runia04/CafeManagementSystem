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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserReport));
            this.userAndDateWiseButton = new System.Windows.Forms.Button();
            this.dateToTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dateFromTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.userComboBox = new System.Windows.Forms.ComboBox();
            this.userWiseButton = new System.Windows.Forms.Button();
            this.itemDataGridView = new System.Windows.Forms.DataGridView();
            this.Details = new System.Windows.Forms.DataGridViewLinkColumn();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.totalAmountlabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.printButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.orderToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.itemDataGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // userAndDateWiseButton
            // 
            this.userAndDateWiseButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.userAndDateWiseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userAndDateWiseButton.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userAndDateWiseButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.userAndDateWiseButton.Location = new System.Drawing.Point(632, 152);
            this.userAndDateWiseButton.Margin = new System.Windows.Forms.Padding(2);
            this.userAndDateWiseButton.Name = "userAndDateWiseButton";
            this.userAndDateWiseButton.Size = new System.Drawing.Size(227, 31);
            this.userAndDateWiseButton.TabIndex = 33;
            this.userAndDateWiseButton.Text = "User And Date Wise";
            this.userAndDateWiseButton.UseVisualStyleBackColor = false;
            this.userAndDateWiseButton.Click += new System.EventHandler(this.userAndDateWiseButton_Click);
            // 
            // dateToTimePicker
            // 
            this.dateToTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateToTimePicker.Location = new System.Drawing.Point(412, 158);
            this.dateToTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.dateToTimePicker.MaxDate = new System.DateTime(2032, 1, 31, 0, 0, 0, 0);
            this.dateToTimePicker.MinDate = new System.DateTime(2024, 11, 1, 0, 0, 0, 0);
            this.dateToTimePicker.Name = "dateToTimePicker";
            this.dateToTimePicker.Size = new System.Drawing.Size(202, 25);
            this.dateToTimePicker.TabIndex = 32;
            this.dateToTimePicker.Value = new System.DateTime(2024, 12, 2, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(367, 158);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 29);
            this.label3.TabIndex = 31;
            this.label3.Text = "To";
            // 
            // dateFromTimePicker
            // 
            this.dateFromTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFromTimePicker.Location = new System.Drawing.Point(144, 158);
            this.dateFromTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.dateFromTimePicker.MaxDate = new System.DateTime(2032, 1, 31, 0, 0, 0, 0);
            this.dateFromTimePicker.MinDate = new System.DateTime(2024, 11, 1, 0, 0, 0, 0);
            this.dateFromTimePicker.Name = "dateFromTimePicker";
            this.dateFromTimePicker.Size = new System.Drawing.Size(202, 25);
            this.dateFromTimePicker.TabIndex = 30;
            this.dateFromTimePicker.Value = new System.DateTime(2024, 11, 1, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 158);
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
            this.label1.Location = new System.Drawing.Point(258, 55);
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
            this.label4.Location = new System.Drawing.Point(31, 113);
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
            this.userComboBox.Location = new System.Drawing.Point(155, 112);
            this.userComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.userComboBox.Name = "userComboBox";
            this.userComboBox.Size = new System.Drawing.Size(119, 35);
            this.userComboBox.TabIndex = 36;
            this.userComboBox.Text = "-Select-";
            this.userComboBox.SelectedIndexChanged += new System.EventHandler(this.userComboBox_SelectedIndexChanged);
            // 
            // userWiseButton
            // 
            this.userWiseButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.userWiseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userWiseButton.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userWiseButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.userWiseButton.Location = new System.Drawing.Point(320, 100);
            this.userWiseButton.Margin = new System.Windows.Forms.Padding(2);
            this.userWiseButton.Name = "userWiseButton";
            this.userWiseButton.Size = new System.Drawing.Size(254, 31);
            this.userWiseButton.TabIndex = 37;
            this.userWiseButton.Text = "User Wise";
            this.userWiseButton.UseVisualStyleBackColor = false;
            this.userWiseButton.Click += new System.EventHandler(this.userWiseButton_Click);
            // 
            // itemDataGridView
            // 
            this.itemDataGridView.AllowUserToOrderColumns = true;
            this.itemDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.itemDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Details});
            this.itemDataGridView.Location = new System.Drawing.Point(83, 254);
            this.itemDataGridView.Name = "itemDataGridView";
            this.itemDataGridView.RowHeadersWidth = 62;
            this.itemDataGridView.RowTemplate.Height = 27;
            this.itemDataGridView.Size = new System.Drawing.Size(679, 362);
            this.itemDataGridView.TabIndex = 38;
            this.itemDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.itemDataGridView_CellContentClick);
            // 
            // Details
            // 
            this.Details.ActiveLinkColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.Details.DefaultCellStyle = dataGridViewCellStyle4;
            this.Details.HeaderText = "Details";
            this.Details.LinkColor = System.Drawing.Color.Maroon;
            this.Details.MinimumWidth = 8;
            this.Details.Name = "Details";
            this.Details.Text = "Details";
            this.Details.UseColumnTextForLinkValue = true;
            this.Details.Width = 150;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // totalAmountlabel
            // 
            this.totalAmountlabel.AutoSize = true;
            this.totalAmountlabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalAmountlabel.Location = new System.Drawing.Point(259, 202);
            this.totalAmountlabel.Name = "totalAmountlabel";
            this.totalAmountlabel.Size = new System.Drawing.Size(58, 27);
            this.totalAmountlabel.TabIndex = 40;
            this.totalAmountlabel.Text = "0.00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(44, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(187, 29);
            this.label5.TabIndex = 39;
            this.label5.Text = "Total Amount : ";
            // 
            // printButton
            // 
            this.printButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.printButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.printButton.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.printButton.Location = new System.Drawing.Point(320, 622);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(165, 47);
            this.printButton.TabIndex = 41;
            this.printButton.Text = "Print";
            this.printButton.UseVisualStyleBackColor = false;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userToolStripMenuItem,
            this.orderToolStripMenuItem,
            this.itemsToolStripMenuItem,
            this.reportsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(894, 33);
            this.menuStrip1.TabIndex = 42;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(71, 29);
            this.userToolStripMenuItem.Text = "Users";
            this.userToolStripMenuItem.Click += new System.EventHandler(this.userToolStripMenuItem_Click);
            // 
            // orderToolStripMenuItem
            // 
            this.orderToolStripMenuItem.Name = "orderToolStripMenuItem";
            this.orderToolStripMenuItem.Size = new System.Drawing.Size(82, 29);
            this.orderToolStripMenuItem.Text = "Orders";
            this.orderToolStripMenuItem.Click += new System.EventHandler(this.orderToolStripMenuItem_Click_1);
            // 
            // itemsToolStripMenuItem
            // 
            this.itemsToolStripMenuItem.Name = "itemsToolStripMenuItem";
            this.itemsToolStripMenuItem.Size = new System.Drawing.Size(72, 29);
            this.itemsToolStripMenuItem.Text = "Items";
            this.itemsToolStripMenuItem.Click += new System.EventHandler(this.itemsToolStripMenuItem_Click_1);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userToolStripMenuItem1,
            this.orderToolStripMenuItem1});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(89, 29);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // userToolStripMenuItem1
            // 
            this.userToolStripMenuItem1.Name = "userToolStripMenuItem1";
            this.userToolStripMenuItem1.Size = new System.Drawing.Size(270, 34);
            this.userToolStripMenuItem1.Text = "User ";
            this.userToolStripMenuItem1.Click += new System.EventHandler(this.userToolStripMenuItem1_Click_1);
            // 
            // orderToolStripMenuItem1
            // 
            this.orderToolStripMenuItem1.Name = "orderToolStripMenuItem1";
            this.orderToolStripMenuItem1.Size = new System.Drawing.Size(270, 34);
            this.orderToolStripMenuItem1.Text = "Order";
            this.orderToolStripMenuItem1.Click += new System.EventHandler(this.orderToolStripMenuItem1_Click_1);
            // 
            // UserReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(894, 671);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.totalAmountlabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.itemDataGridView);
            this.Controls.Add(this.userWiseButton);
            this.Controls.Add(this.userComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userAndDateWiseButton);
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
            ((System.ComponentModel.ISupportInitialize)(this.itemDataGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button userAndDateWiseButton;
        private System.Windows.Forms.DateTimePicker dateToTimePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateFromTimePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox userComboBox;
        private System.Windows.Forms.Button userWiseButton;
        private System.Windows.Forms.DataGridView itemDataGridView;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Label totalAmountlabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewLinkColumn Details;
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem orderToolStripMenuItem1;
    }
}