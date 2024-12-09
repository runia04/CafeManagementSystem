namespace CafeManagementSystem
{
    partial class UsersForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.logoutLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.phoneNoTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.editButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.usersGV = new System.Windows.Forms.DataGridView();
            this.manageItemsLabel = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.orderButton = new System.Windows.Forms.Button();
            this.itemsButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.orderToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.isAdminCheckBox = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersGV)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // logoutLabel
            // 
            this.logoutLabel.AutoSize = true;
            this.logoutLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.logoutLabel.Font = new System.Drawing.Font("Arial", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.logoutLabel.Location = new System.Drawing.Point(12, 673);
            this.logoutLabel.Name = "logoutLabel";
            this.logoutLabel.Size = new System.Drawing.Size(113, 33);
            this.logoutLabel.TabIndex = 25;
            this.logoutLabel.Text = "LogOut";
            this.logoutLabel.Click += new System.EventHandler(this.logoutLabel_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.isAdminCheckBox);
            this.panel1.Controls.Add(this.idTextBox);
            this.panel1.Controls.Add(this.phoneNoTextBox);
            this.panel1.Controls.Add(this.passwordTextBox);
            this.panel1.Controls.Add(this.userNameTextBox);
            this.panel1.Controls.Add(this.editButton);
            this.panel1.Controls.Add(this.deleteButton);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.addButton);
            this.panel1.Controls.Add(this.usersGV);
            this.panel1.Controls.Add(this.manageItemsLabel);
            this.panel1.Location = new System.Drawing.Point(149, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1139, 648);
            this.panel1.TabIndex = 21;
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(220, 139);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(237, 25);
            this.idTextBox.TabIndex = 23;
            this.idTextBox.Visible = false;
            // 
            // phoneNoTextBox
            // 
            this.phoneNoTextBox.Location = new System.Drawing.Point(220, 268);
            this.phoneNoTextBox.Name = "phoneNoTextBox";
            this.phoneNoTextBox.Size = new System.Drawing.Size(237, 25);
            this.phoneNoTextBox.TabIndex = 22;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(220, 345);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(237, 25);
            this.passwordTextBox.TabIndex = 21;
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Location = new System.Drawing.Point(220, 194);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(237, 25);
            this.userNameTextBox.TabIndex = 20;
            // 
            // editButton
            // 
            this.editButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.editButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editButton.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.editButton.Location = new System.Drawing.Point(205, 482);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(124, 47);
            this.editButton.TabIndex = 12;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = false;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.deleteButton.Location = new System.Drawing.Point(346, 482);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(111, 47);
            this.deleteButton.TabIndex = 12;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(702, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 37);
            this.label5.TabIndex = 19;
            this.label5.Text = "Users List";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(38, 337);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 32);
            this.label4.TabIndex = 18;
            this.label4.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(34, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 32);
            this.label3.TabIndex = 16;
            this.label3.Text = "Phone No.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(34, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 32);
            this.label1.TabIndex = 15;
            this.label1.Text = "User Name";
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.addButton.Location = new System.Drawing.Point(44, 482);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(123, 47);
            this.addButton.TabIndex = 12;
            this.addButton.Text = "Add ";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // usersGV
            // 
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            this.usersGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.usersGV.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.usersGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.usersGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.usersGV.DefaultCellStyle = dataGridViewCellStyle5;
            this.usersGV.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.usersGV.Location = new System.Drawing.Point(492, 155);
            this.usersGV.Name = "usersGV";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.usersGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.usersGV.RowHeadersWidth = 62;
            this.usersGV.RowTemplate.Height = 27;
            this.usersGV.Size = new System.Drawing.Size(625, 481);
            this.usersGV.TabIndex = 2;
            this.usersGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.usersGV_CellContentClick);
            // 
            // manageItemsLabel
            // 
            this.manageItemsLabel.AutoSize = true;
            this.manageItemsLabel.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageItemsLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.manageItemsLabel.Location = new System.Drawing.Point(401, 28);
            this.manageItemsLabel.Name = "manageItemsLabel";
            this.manageItemsLabel.Size = new System.Drawing.Size(234, 37);
            this.manageItemsLabel.TabIndex = 0;
            this.manageItemsLabel.Text = "Manage Users";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // orderButton
            // 
            this.orderButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.orderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.orderButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.orderButton.Location = new System.Drawing.Point(12, 183);
            this.orderButton.Name = "orderButton";
            this.orderButton.Size = new System.Drawing.Size(131, 47);
            this.orderButton.TabIndex = 26;
            this.orderButton.Text = "Orders";
            this.orderButton.UseVisualStyleBackColor = false;
            this.orderButton.Click += new System.EventHandler(this.orderButton_Click);
            // 
            // itemsButton
            // 
            this.itemsButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.itemsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemsButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemsButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.itemsButton.Location = new System.Drawing.Point(12, 262);
            this.itemsButton.Name = "itemsButton";
            this.itemsButton.Size = new System.Drawing.Size(131, 47);
            this.itemsButton.TabIndex = 27;
            this.itemsButton.Text = "Items";
            this.itemsButton.UseVisualStyleBackColor = false;
            this.itemsButton.Click += new System.EventHandler(this.itemsButton_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(12, 110);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 47);
            this.button1.TabIndex = 28;
            this.button1.Text = "Users";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(12, 346);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 47);
            this.button2.TabIndex = 29;
            this.button2.Text = "Reports";
            this.button2.UseVisualStyleBackColor = false;
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
            this.menuStrip1.Size = new System.Drawing.Size(1309, 33);
            this.menuStrip1.TabIndex = 30;
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
            this.orderToolStripMenuItem.Click += new System.EventHandler(this.orderToolStripMenuItem_Click);
            // 
            // itemsToolStripMenuItem
            // 
            this.itemsToolStripMenuItem.Name = "itemsToolStripMenuItem";
            this.itemsToolStripMenuItem.Size = new System.Drawing.Size(72, 29);
            this.itemsToolStripMenuItem.Text = "Items";
            this.itemsToolStripMenuItem.Click += new System.EventHandler(this.itemsToolStripMenuItem_Click);
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
            this.userToolStripMenuItem1.Click += new System.EventHandler(this.userToolStripMenuItem1_Click);
            // 
            // orderToolStripMenuItem1
            // 
            this.orderToolStripMenuItem1.Name = "orderToolStripMenuItem1";
            this.orderToolStripMenuItem1.Size = new System.Drawing.Size(270, 34);
            this.orderToolStripMenuItem1.Text = "Order";
            this.orderToolStripMenuItem1.Click += new System.EventHandler(this.orderToolStripMenuItem1_Click);
            // 
            // isAdminCheckBox
            // 
            this.isAdminCheckBox.AutoSize = true;
            this.isAdminCheckBox.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isAdminCheckBox.Location = new System.Drawing.Point(213, 399);
            this.isAdminCheckBox.Name = "isAdminCheckBox";
            this.isAdminCheckBox.Size = new System.Drawing.Size(143, 36);
            this.isAdminCheckBox.TabIndex = 24;
            this.isAdminCheckBox.Text = "IsAdmin";
            this.isAdminCheckBox.UseVisualStyleBackColor = true;
            // 
            // UsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1309, 748);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.itemsButton);
            this.Controls.Add(this.orderButton);
            this.Controls.Add(this.logoutLabel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "UsersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UsersForm";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.UsersForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersGV)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label logoutLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.DataGridView usersGV;
        private System.Windows.Forms.Label manageItemsLabel;
        private System.Windows.Forms.TextBox phoneNoTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button orderButton;
        private System.Windows.Forms.Button itemsButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem orderToolStripMenuItem1;
        private System.Windows.Forms.CheckBox isAdminCheckBox;
    }
}