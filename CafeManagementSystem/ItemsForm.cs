using CafeManagementSystem.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CafeManagementSystem
{
    public partial class ItemsForm : Form
    {
        Data data = new Data();
        public ItemsForm()
        {
            InitializeComponent();
        }
        void populate()
        {
   
            string query = "select * from [Item]";
         
            DataSet ds = data.Populate(query);
            itemsGV.DataSource = ds.Tables[0];
            this.itemsGV.Columns["Id"].Visible = false;

        }
        private void orderNoTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void ItemsForm_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void usersButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            UsersForm usersForm = new UsersForm();
            usersForm.Show();
        }

        private void ordersButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserOrder userOrder = new UserOrder();
            userOrder.Show();

        }

        private void logoutLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 login = new Form1();
            login.Show();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if(itemNameTextBox.Text==""|| itemNoTextBox.Text == "" || itemPriceTextBox.Text == "")
            {
                MessageBox.Show("Fill All The Data.");
            }
            else
            {
                try
                {
                    if (categoryComboBox.SelectedIndex == -1)
                    {
                        MessageBox.Show("Please select category.");
                       
                    }
                    else
                    {
                        string value = categoryComboBox.SelectedItem.ToString();
                        string query = "Insert into [Item](No,Name,Category,Price) VALUES('" + itemNoTextBox.Text + "','" + itemNameTextBox.Text + "','" + categoryComboBox.SelectedItem.ToString() + "','" + itemPriceTextBox.Text + "')";
                        int rowNo = data.AllFuntion(query);
                        if (rowNo > 0)
                        {
                            MessageBox.Show("Item created successfully.");


                            populate();
                        }
                        else
                        {
                            MessageBox.Show("Item not created.");

                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        
        private void itemNameTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void closeLabel_Click(object sender, EventArgs e)
        {

        }

        private void itemsGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                idTextBox.Text = itemsGV.Rows[e.RowIndex].Cells[0].Value.ToString();
                itemNoTextBox.Text = itemsGV.Rows[e.RowIndex].Cells[1].Value.ToString();
                itemNameTextBox.Text = itemsGV.Rows[e.RowIndex].Cells[2].Value.ToString();
                categoryComboBox.SelectedItem = itemsGV.Rows[e.RowIndex].Cells[3].Value.ToString();
                itemPriceTextBox.Text = itemsGV.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
            catch
            {

            }
        }
    }
}


