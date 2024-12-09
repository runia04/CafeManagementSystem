namespace CafeManagementSystem
{
    partial class ItemsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.closeLabel = new System.Windows.Forms.Label();
            this.manageItemsLabel = new System.Windows.Forms.Label();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.itemNoTextBox = new System.Windows.Forms.MaskedTextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.itemPriceTextBox = new System.Windows.Forms.TextBox();
            this.itemNameTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.MaskedTextBox();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.itemsGV = new System.Windows.Forms.DataGridView();
            this.logoutLabel = new System.Windows.Forms.Label();
            this.ordersButton = new System.Windows.Forms.Button();
            this.usersButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.orderToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemsGV)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // closeLabel
            // 
            this.closeLabel.AutoSize = true;
            this.closeLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.closeLabel.Location = new System.Drawing.Point(1251, 17);
            this.closeLabel.Name = "closeLabel";
            this.closeLabel.Size = new System.Drawing.Size(27, 27);
            this.closeLabel.TabIndex = 16;
            this.closeLabel.Text = "X";
            this.closeLabel.Click += new System.EventHandler(this.closeLabel_Click);
            // 
            // manageItemsLabel
            // 
            this.manageItemsLabel.AutoSize = true;
            this.manageItemsLabel.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageItemsLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.manageItemsLabel.Location = new System.Drawing.Point(424, 35);
            this.manageItemsLabel.Name = "manageItemsLabel";
            this.manageItemsLabel.Size = new System.Drawing.Size(228, 37);
            this.manageItemsLabel.TabIndex = 0;
            this.manageItemsLabel.Text = "Manage Items";
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Items.AddRange(new object[] {
            "Food",
            "Bevarage"});
            this.categoryComboBox.Location = new System.Drawing.Point(190, 405);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(201, 35);
            this.categoryComboBox.TabIndex = 1;
            this.categoryComboBox.Text = "-Select-";
            // 
            // itemNoTextBox
            // 
            this.itemNoTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemNoTextBox.Location = new System.Drawing.Point(190, 231);
            this.itemNoTextBox.Name = "itemNoTextBox";
            this.itemNoTextBox.ReadOnly = true;
            this.itemNoTextBox.Size = new System.Drawing.Size(201, 35);
            this.itemNoTextBox.TabIndex = 9;
            this.itemNoTextBox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.orderNoTextBox_MaskInputRejected);
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.addButton.Location = new System.Drawing.Point(24, 605);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(94, 47);
            this.addButton.TabIndex = 12;
            this.addButton.Text = "Add ";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(5, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 37);
            this.label1.TabIndex = 15;
            this.label1.Text = "Item No.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(-2, 317);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 37);
            this.label3.TabIndex = 16;
            this.label3.Text = "Item Name";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(5, 491);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 37);
            this.label4.TabIndex = 18;
            this.label4.Text = "Item Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(708, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 37);
            this.label5.TabIndex = 19;
            this.label5.Text = "Items List";
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.deleteButton.Location = new System.Drawing.Point(263, 605);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(104, 47);
            this.deleteButton.TabIndex = 12;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // editButton
            // 
            this.editButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.editButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editButton.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.editButton.Location = new System.Drawing.Point(142, 605);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(94, 47);
            this.editButton.TabIndex = 12;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = false;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.itemPriceTextBox);
            this.panel1.Controls.Add(this.itemNameTextBox);
            this.panel1.Controls.Add(this.idTextBox);
            this.panel1.Controls.Add(this.categoryLabel);
            this.panel1.Controls.Add(this.itemsGV);
            this.panel1.Controls.Add(this.editButton);
            this.panel1.Controls.Add(this.deleteButton);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.addButton);
            this.panel1.Controls.Add(this.itemNoTextBox);
            this.panel1.Controls.Add(this.categoryComboBox);
            this.panel1.Controls.Add(this.manageItemsLabel);
            this.panel1.Location = new System.Drawing.Point(159, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1119, 777);
            this.panel1.TabIndex = 12;
            // 
            // itemPriceTextBox
            // 
            this.itemPriceTextBox.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemPriceTextBox.Location = new System.Drawing.Point(190, 503);
            this.itemPriceTextBox.Name = "itemPriceTextBox";
            this.itemPriceTextBox.Size = new System.Drawing.Size(201, 28);
            this.itemPriceTextBox.TabIndex = 24;
            // 
            // itemNameTextBox
            // 
            this.itemNameTextBox.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemNameTextBox.Location = new System.Drawing.Point(190, 329);
            this.itemNameTextBox.Name = "itemNameTextBox";
            this.itemNameTextBox.Size = new System.Drawing.Size(201, 28);
            this.itemNameTextBox.TabIndex = 23;
            // 
            // idTextBox
            // 
            this.idTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTextBox.Location = new System.Drawing.Point(190, 178);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(201, 35);
            this.idTextBox.TabIndex = 22;
            this.idTextBox.Visible = false;
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.categoryLabel.Location = new System.Drawing.Point(3, 405);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(155, 37);
            this.categoryLabel.TabIndex = 21;
            this.categoryLabel.Text = "Category";
            // 
            // itemsGV
            // 
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            this.itemsGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.itemsGV.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.itemsGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.itemsGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.itemsGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.itemsGV.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.itemsGV.Location = new System.Drawing.Point(413, 196);
            this.itemsGV.Name = "itemsGV";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.itemsGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.itemsGV.RowHeadersWidth = 62;
            this.itemsGV.RowTemplate.Height = 27;
            this.itemsGV.Size = new System.Drawing.Size(681, 481);
            this.itemsGV.TabIndex = 20;
            this.itemsGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.itemsGV_CellContentClick);
            // 
            // logoutLabel
            // 
            this.logoutLabel.AutoSize = true;
            this.logoutLabel.Font = new System.Drawing.Font("Arial", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.logoutLabel.Location = new System.Drawing.Point(17, 782);
            this.logoutLabel.Name = "logoutLabel";
            this.logoutLabel.Size = new System.Drawing.Size(113, 33);
            this.logoutLabel.TabIndex = 20;
            this.logoutLabel.Text = "LogOut";
            this.logoutLabel.Click += new System.EventHandler(this.logoutLabel_Click);
            // 
            // ordersButton
            // 
            this.ordersButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ordersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ordersButton.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ordersButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ordersButton.Location = new System.Drawing.Point(36, 161);
            this.ordersButton.Name = "ordersButton";
            this.ordersButton.Size = new System.Drawing.Size(94, 47);
            this.ordersButton.TabIndex = 21;
            this.ordersButton.Text = "Orders";
            this.ordersButton.UseVisualStyleBackColor = false;
            this.ordersButton.Click += new System.EventHandler(this.ordersButton_Click);
            // 
            // usersButton
            // 
            this.usersButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.usersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.usersButton.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usersButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.usersButton.Location = new System.Drawing.Point(36, 272);
            this.usersButton.Name = "usersButton";
            this.usersButton.Size = new System.Drawing.Size(94, 47);
            this.usersButton.TabIndex = 22;
            this.usersButton.Text = "Users";
            this.usersButton.UseVisualStyleBackColor = false;
            this.usersButton.Click += new System.EventHandler(this.usersButton_Click);
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
            this.menuStrip1.Size = new System.Drawing.Size(1303, 36);
            this.menuStrip1.TabIndex = 31;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(71, 30);
            this.userToolStripMenuItem.Text = "Users";
            this.userToolStripMenuItem.Click += new System.EventHandler(this.userToolStripMenuItem_Click);
            // 
            // orderToolStripMenuItem
            // 
            this.orderToolStripMenuItem.Name = "orderToolStripMenuItem";
            this.orderToolStripMenuItem.Size = new System.Drawing.Size(82, 30);
            this.orderToolStripMenuItem.Text = "Orders";
            // 
            // itemsToolStripMenuItem
            // 
            this.itemsToolStripMenuItem.Name = "itemsToolStripMenuItem";
            this.itemsToolStripMenuItem.Size = new System.Drawing.Size(72, 30);
            this.itemsToolStripMenuItem.Text = "Items";
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userToolStripMenuItem1,
            this.orderToolStripMenuItem1});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(89, 30);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // userToolStripMenuItem1
            // 
            this.userToolStripMenuItem1.Name = "userToolStripMenuItem1";
            this.userToolStripMenuItem1.Size = new System.Drawing.Size(160, 34);
            this.userToolStripMenuItem1.Text = "User ";
            // 
            // orderToolStripMenuItem1
            // 
            this.orderToolStripMenuItem1.Name = "orderToolStripMenuItem1";
            this.orderToolStripMenuItem1.Size = new System.Drawing.Size(160, 34);
            this.orderToolStripMenuItem1.Text = "Order";
            // 
            // ItemsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1303, 855);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.usersButton);
            this.Controls.Add(this.ordersButton);
            this.Controls.Add(this.logoutLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.closeLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ItemsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ItemsForm";
            this.Load += new System.EventHandler(this.ItemsForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemsGV)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label closeLabel;
        private System.Windows.Forms.Label manageItemsLabel;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.MaskedTextBox itemNoTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label logoutLabel;
        private System.Windows.Forms.Button ordersButton;
        private System.Windows.Forms.Button usersButton;
        private System.Windows.Forms.DataGridView itemsGV;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.MaskedTextBox idTextBox;
        private System.Windows.Forms.TextBox itemNameTextBox;
        private System.Windows.Forms.TextBox itemPriceTextBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem orderToolStripMenuItem1;
    }
}