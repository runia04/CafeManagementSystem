using CafeManagementSystem.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
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
            int check = 0;
            bool checkBoxCell = false;
            int quantityCount = 0;
            int orderQnty = 0;
            try
            {
                if (itemDataGridView.Rows.Count > 0)
                {

                    for (int i = 0; i < itemDataGridView.Rows.Count; i++)
                    {

                        try
                        {
                            if (itemDataGridView.Rows[i].Cells[0].Value != null)
                            {

                                checkBoxCell = (bool)itemDataGridView.Rows[i].Cells[0].Value;
                                if (checkBoxCell)
                                {
                                    check++;

                                }

                                try
                                {
                                    if (itemDataGridView.Rows[i].Cells[6].Value == null)
                                    {
                                        MessageBox.Show("Enter order quantity.");
                                        break;
                                    }
                                    string quantity = itemDataGridView.Rows[i].Cells[6].Value.ToString();
                                    orderQnty = int.Parse(quantity);
                                    quantityCount++;
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("Enter order quantity.");
                                    break;
                                }
                            }

                        }
                        catch
                        {
                            checkBoxCell = false;
                        }


                    }
                    if (check == 0)
                    {
                        MessageBox.Show("Select item for order");
                    }
                }
                decimal price = 0;
                decimal totalPrice = 0;
                if (quantityCount == check)
                {
                for (int i = 0; i < itemDataGridView.Rows.Count; i++)
                {
                    try
                    {
                        if (itemDataGridView.Rows[i].Cells[0].Value != null)
                        {
                            int itemId = int.Parse(itemDataGridView.Rows[i].Cells[1].Value.ToString());
                            string quantity = itemDataGridView.Rows[i].Cells[6].Value.ToString();
                            orderQnty = int.Parse(quantity);
                            string price1 = itemDataGridView.Rows[i].Cells[5].Value.ToString();
                            price = decimal.Parse(price1);
                            totalPrice = price * orderQnty;
                            string category= itemDataGridView.Rows[i].Cells[4].Value.ToString();
                            string itemName = itemDataGridView.Rows[i].Cells[3].Value.ToString();
                            string sql = "Insert into TempOrder Values('" + category+ "','" + itemId+ "','"+itemName+ "','" + quantity+ "','" + price+ "','"+totalPrice+ "','true')";
                            int result = data.AllFuntion(sql);
                        }
                    }
                    catch (Exception ex)
                    {

                    }
                }
                    LoadOrderDataGV();
                    PopulateOrderDT();
            }
                }
            catch
            {

            }
        }

        private void LoadOrderDataGV()
        {
            data = new Data();
            string query = "select * from [TempOrder]";

            DataSet ds = data.Populate(query);
            orderDataGridView.DataSource = ds.Tables[0];
            //this.orderDataGridView.Columns["Id"].Visible = false;
            //this.orderDataGridView.Columns["ItemId"].Visible = false;
            //this.orderDataGridView.Columns["IsUser"].Visible = false;
            //this.orderDataGridView.Columns["Price"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;    
            //this.orderDataGridView.Columns["Price"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            //this.orderDataGridView.Columns["Qunatity"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            //this.orderDataGridView.Columns["Qunatity"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            //this.orderDataGridView.Columns["TotalPrice"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            //this.orderDataGridView.Columns["TotalPrice"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            data = new Data();
            query = "SELECT SUM (TotalPrice)FROM TempOrder WHERE IsUser='true'";

            decimal totalPrice = data.GetTempOrderTotalPrice(query);
            orderAmountlabel.Text = totalPrice.ToString()+ "¥";
        }

        private void UserOrder_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cafeDBDataSet1.TempOrder' table. You can move, or remove it, as needed.
            this.tempOrderTableAdapter.Fill(this.cafeDBDataSet1.TempOrder);
            // TODO: This line of code loads data into the 'cafeDBDataSet.Item' table. You can move, or remove it, as needed.
            this.itemTableAdapter.Fill(this.cafeDBDataSet.Item);
            PopulateOrderDT();
            DeleteDataFromTempOrder();
            dateLabel.Text = DateTime.Today.Date.ToString("MM/dd/yy");
            CreateOrderNo();
        }

        private void CreateOrderNo()
        {
       
            string orderNo = GetOrderNo();
            string newOrderNo = "";
            if (orderNo=="" || orderNo == null)
            {
                orderNo= "0001";
            }
            else
            {
               
                int number = int.Parse(orderNo);
                number++;
                int length = number.ToString().Length;
                for(int i = 0; i < 4 - length; i++)
                {
                    newOrderNo = newOrderNo + "" + "0";
                }
                newOrderNo = newOrderNo + number.ToString();
            }
            orderNoLabel.Text = newOrderNo;
            InsetOrderSerial();
        }

        private string GetOrderNo()
        {

            int year = DateTime.Today.Year;
            int month = DateTime.Today.Month;
            int day = DateTime.Today.Day;
            data = new Data();
            string query = "Select TOP(1) Number FROM OrderSerial WHERE Day='" + day + "' AND Month='" + month + "' AND Year='" + year + "' ORDER BY ID DESC";
            return  data.GetOrderNo(query);
        }

        private void InsetOrderSerial()
        {
            int year = DateTime.Today.Year;
            int month = DateTime.Today.Month;
            int day = DateTime.Today.Day;
       
                data = new Data();
                string query = "INSERT INTO OrderSerial VALUES ('" + day + "' , '" + month + "' , '" + year + "', '" + orderNoLabel.Text + "')";
                data.AllFuntion(query);
           
        }

        private void DeleteDataFromTempOrder()
        {
            string query = "DELETE FROM TempOrder WHERE IsUser='true'";
            
            int result = data.AllFuntion(query);
          
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
       

        }
     

        private void categoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
                PopulateOrderDT();
            
        }
       

        private void itemsGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
       
        }

        private void orderDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
