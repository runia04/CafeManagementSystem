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
        void populateItemDataGrid()
        {

            string query = "select * from [Item]";

            DataSet ds = data.Populate(query);
            itemsGV.DataSource = ds.Tables[0];
            this.itemsGV.Columns["Id"].Visible = false;
            this.itemsGV.Columns["Price"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.itemsGV.Columns["Price"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }
        private void orderNoTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void ItemsForm_Load(object sender, EventArgs e)
        {
            populateItemDataGrid();
            PopultaeItemNo();
        }

        private void PopultaeItemNo()
        {
            int itemNo = 0;
            try
            {
                if (itemsGV.Rows.Count > 1)
                {

                    string sql = "Select Top(1) No From [Item] Order by ID DESC";
                    itemNo = data.GetIntegerColumnValue(sql);
                }
            }
            catch(Exception ex)
            {

            }
           
            itemNo++;
            itemNoTextBox.Text = itemNo.ToString();
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
            if (itemNameTextBox.Text == "" || itemNoTextBox.Text == "" || itemPriceTextBox.Text == "")
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
                        try
                        {
                            decimal.Parse(itemPriceTextBox.Text);
                        }
                        catch
                        {
                            MessageBox.Show("Please enter price");
                        }
                        string value = categoryComboBox.SelectedItem.ToString();
                        string query = "Insert into [Item](No,Name,Category,Price) VALUES('" + itemNoTextBox.Text + "','" + itemNameTextBox.Text + "','" + categoryComboBox.SelectedItem.ToString() + "','" + itemPriceTextBox.Text + "')";
                        int rowNo = data.AllFuntion(query);
                        if (rowNo > 0)
                        {
                            MessageBox.Show("Item created successfully.");


                            populateItemDataGrid();
                            PopultaeItemNo();
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
                itemPriceTextBox.Text = itemsGV.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
            catch
            {

            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (itemPriceTextBox.Text == "" || itemNameTextBox.Text == null)
            {
                MessageBox.Show("Select the item to be deleted.");
            }
            else
            {
                int id = Convert.ToInt32(idTextBox.Text);
                string query = "Delete From [Item] Where Id='" + id + "'";
                int rowNo = data.AllFuntion(query);
                if (rowNo > 0)
                {
                    MessageBox.Show("User deleted successfully.");
                    idTextBox.Text = "";
                    itemNoTextBox.Text = "";
                    itemNameTextBox.Text = "";
                    itemPriceTextBox.Text = "";
                    populateItemDataGrid();
                    PopultaeItemNo();
                }
                else
                {
                    MessageBox.Show("User not deleted.");

                }
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            int id = 0;

            try { id = Convert.ToInt32(idTextBox.Text); }
            catch
            {
                MessageBox.Show("Select the item.");
                return;
            }
            if (itemPriceTextBox.Text == "" || itemNameTextBox.Text == "" || categoryComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Fillup all the fields.");
            }
            else
            {
                try
                {
                    decimal.Parse(itemPriceTextBox.Text);
                }
                catch
                {
                    MessageBox.Show("Please enter price");
                    return;
                }
                try
                {


                    string query = "Update [Item] Set Name='" + itemNameTextBox.Text + "',Price='" + itemPriceTextBox.Text + "',Category='" + categoryComboBox.SelectedItem.ToString() + "' Where Id='" + id + "'";
                    int rowNo = data.AllFuntion(query);
                    if (rowNo > 0)
                    {
                        MessageBox.Show("Item updated successfully.");


                        populateItemDataGrid();
                    }
                    else
                    {
                        MessageBox.Show("Item not updated.");

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

      

    

        private void orderToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            UserOrder userOrder = new UserOrder();
            userOrder.Show();
        }

        private void userToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            UsersForm usersForm = new UsersForm();
            usersForm.Show();
        }

        private void itemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ItemsForm itemsForm = new ItemsForm();
            itemsForm.Show();
        }

        private void userToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserReport userReport = new UserReport();
            userReport.Show();
        }

        private void orderToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewOrderList viewOrderList = new ViewOrderList();
            viewOrderList.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}


