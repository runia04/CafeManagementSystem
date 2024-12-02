namespace CafeManagementSystem
{
    partial class ViewOrderList
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
            this.itemDataGridView = new System.Windows.Forms.DataGridView();
            this.Details = new System.Windows.Forms.DataGridViewLinkColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateFromTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dateToTimePicker = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.itemDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // itemDataGridView
            // 
            this.itemDataGridView.AllowUserToOrderColumns = true;
            this.itemDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.itemDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Details});
            this.itemDataGridView.Location = new System.Drawing.Point(45, 176);
            this.itemDataGridView.Name = "itemDataGridView";
            this.itemDataGridView.RowHeadersWidth = 62;
            this.itemDataGridView.RowTemplate.Height = 27;
            this.itemDataGridView.Size = new System.Drawing.Size(1170, 229);
            this.itemDataGridView.TabIndex = 21;
            this.itemDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.itemDataGridView_CellContentClick);
            // 
            // Details
            // 
            this.Details.ActiveLinkColor = System.Drawing.Color.Maroon;
            this.Details.HeaderText = "";
            this.Details.LinkColor = System.Drawing.Color.Maroon;
            this.Details.MinimumWidth = 8;
            this.Details.Name = "Details";
            this.Details.Text = "Details";
            this.Details.UseColumnTextForLinkValue = true;
            this.Details.Width = 150;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(441, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 37);
            this.label1.TabIndex = 20;
            this.label1.Text = "Order List";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(70, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 24);
            this.label2.TabIndex = 22;
            this.label2.Text = "Date : ";
            // 
            // dateFromTimePicker
            // 
            this.dateFromTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFromTimePicker.Location = new System.Drawing.Point(176, 117);
            this.dateFromTimePicker.MaxDate = new System.DateTime(2024, 12, 2, 0, 0, 0, 0);
            this.dateFromTimePicker.MinDate = new System.DateTime(2024, 11, 1, 0, 0, 0, 0);
            this.dateFromTimePicker.Name = "dateFromTimePicker";
            this.dateFromTimePicker.Size = new System.Drawing.Size(200, 25);
            this.dateFromTimePicker.TabIndex = 23;
            this.dateFromTimePicker.Value = new System.DateTime(2024, 11, 1, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(415, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 29);
            this.label3.TabIndex = 24;
            this.label3.Text = "To";
            // 
            // dateToTimePicker
            // 
            this.dateToTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateToTimePicker.Location = new System.Drawing.Point(493, 113);
            this.dateToTimePicker.MaxDate = new System.DateTime(2024, 12, 2, 0, 0, 0, 0);
            this.dateToTimePicker.MinDate = new System.DateTime(2024, 11, 1, 0, 0, 0, 0);
            this.dateToTimePicker.Name = "dateToTimePicker";
            this.dateToTimePicker.Size = new System.Drawing.Size(200, 25);
            this.dateToTimePicker.TabIndex = 25;
            this.dateToTimePicker.Value = new System.DateTime(2024, 12, 2, 0, 0, 0, 0);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(739, 96);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(236, 47);
            this.button2.TabIndex = 28;
            this.button2.Text = "View";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ViewOrderList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1227, 855);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dateToTimePicker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateFromTimePicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.itemDataGridView);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewOrderList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.ViewOrderList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.itemDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView itemDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateFromTimePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateToTimePicker;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewLinkColumn Details;
    }
}