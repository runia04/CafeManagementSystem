using CafeManagementSystem.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CafeManagementSystem
{
    public partial class UserOrder : Form
    {
        Data data = new Data();
        
        public UserOrder()
        {
            InitializeComponent();
        }

        private void closeLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void logoutLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 login = new Form1();
            login.Show();
           
        }

        private void itemsLabel_Click(object sender, EventArgs e)
        {

        }

        private void ordersButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ItemsForm item = new ItemsForm();
            item.Show();
            
        }

        private void usersButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            UsersForm usersForm = new UsersForm();
            usersForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (quantityTextBox.Text == "")
            {
                MessageBox.Show("PLease enter quantity");
            }
        }

        private void UserOrder_Load(object sender, EventArgs e)
        {
            PopulateOrderDT();
        }

        private void PopulateOrderDT()
        {
           
           
                string query = "select * from [item]";
            if (categoryComboBox.SelectedIndex != -1)
            {
                query = query+ " Where Category='" + categoryComboBox.SelectedItem.ToString() + "'";
            }
            DataSet ds = data.Populate(query);
            itemDataGridView.DataSource = ds.Tables[0];
            //    this.itemsGV.Columns["Id"].Visible = false;
            //this.itemsGV.Columns["Price"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            ////   this.itemsGV.Columns["Price"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            //this.itemsGV.Columns["Price"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

        }
        int no = 0,qnty=0;
        decimal price = 0, totalPrice = 0;

        private void categoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
                PopulateOrderDT();
            
        }
        //no = int.Parse(itemsGV.Rows[e.RowIndex].Cells[0].Value.ToString());
        ////  itemNoTextBox.Text = itemsGV.Rows[e.RowIndex].Cells[1].Value.ToString();
        //itemName = itemsGV.Rows[e.RowIndex].Cells[1].Value.ToString();
        //category = itemsGV.Rows[e.RowIndex].Cells[2].Value.ToString();
        //price = decimal.Parse(itemsGV.Rows[e.RowIndex].Cells[3].Value.ToString());
        //totalPrice = decimal.Parse(itemsGV.Rows[e.RowIndex].Cells[4].Value.ToString());

        private void itemsGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //no = int.Parse(itemsGV.Rows[e.RowIndex].Cells[0].Value.ToString());
            ////  itemNoTextBox.Text = itemsGV.Rows[e.RowIndex].Cells[1].Value.ToString();
            //itemName = itemsGV.Rows[e.RowIndex].Cells[1].Value.ToString();
            //category = itemsGV.Rows[e.RowIndex].Cells[2].Value.ToString();
            //price = decimal.Parse(itemsGV.Rows[e.RowIndex].Cells[3].Value.ToString());
            //totalPrice = decimal.Parse(itemsGV.Rows[e.RowIndex].Cells[4].Value.ToString());
        }

        string itemName = "", category="";
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
       
        }
    }
}
