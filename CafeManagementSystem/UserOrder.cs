using CafeManagementSystem.BLL;
using CafeManagementSystem.Model;
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
                                     //   itemDataGridView.Rows[i].Cells[6].Value = "Enter Quantity";
                                        MessageBox.Show("Enter selected item  order quantity.");
                                        return;
                                    }
                                   
                                    try
                                    {
                                        if (itemDataGridView.Rows[i].Cells[6].Value != null)
                                        {
                                            string quantity = itemDataGridView.Rows[i].Cells[6].Value.ToString();
                                            orderQnty = int.Parse(quantity);
                                            quantityCount++;
                                        }
                                    }
                                    catch { }
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("Enter order quantity.");
                                    ;
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
                    OrderButtonEnabled();
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
                     data = new Data();
            query = "SELECT SUM (TotalPrice)FROM TempOrder WHERE IsUser='true'";

            decimal totalPrice = data.GetTempOrderTotalPrice(query);
            orderAmountlabel.Text = totalPrice.ToString();
        }

        private void UserOrder_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cafeDBDataSet1.TempOrder' table. You can move, or remove it, as needed.
            this.tempOrderTableAdapter.Fill(this.cafeDBDataSet1.TempOrder);
            // TODO: This line of code loads data into the 'cafeDBDataSet.Item' table. You can move, or remove it, as needed.
            this.itemTableAdapter.Fill(this.cafeDBDataSet.Item);
            try
            {
                string value = this.Tag.ToString();

                bool isAdmin = bool.Parse(value);
                if (!isAdmin)
                {
                    menuStrip1.Visible = false;
                    exitlabel.Visible = true;
                }
                else
                {
                    menuStrip1.Visible = true;
                    exitlabel.Visible = false;
                }
            }
            catch
            {
                menuStrip1.Visible = true;
                exitlabel.Visible = false;
            }
            DeleteDataFromTempOrder();
            LoadOrderDataGV();
            PopulateOrderDT();
            dateLabel.Text = DateTime.Today.Date.ToString("MM/dd/yy");
            CreateOrderNo();
            OrderButtonEnabled();
            GetUserName();
        }

        private void GetUserName()
        {
            data=new Data ();
            string sql = "Select Name FROM [User] WHERE IsLoggedIn='true'";
            string  name = data.GetStringColumnValue(sql);
            sellerLabel.Text = name;
            sql = "Select Id FROM [User] WHERE IsLoggedIn='true'";
            int userId = data.GetIntegerColumnValue(sql);
            userIDLabel.Text = userId.ToString();
        }

        private void OrderButtonEnabled()
        {
            try
            {
                if (orderDataGridView.RowCount > 1)
                {
                    orderButton.Enabled = true;
                }
                else
                {
                    orderButton.Enabled = false;
                }
            }
            catch
            {

            }
        }

        private void CreateOrderNo()
        {
       
            string orderNo = GetOrderNo();
            string newOrderNo = "";
            if (orderNo=="" || orderNo == null)
            {
                newOrderNo = "0001";
            }
            else
            {
               
                int number = int.Parse(orderNo);
                number++;
                int length = number.ToString().Length;
                for(int i = 0; i < 5 - length; i++)
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
            return  data.GetStringColumnValue(query);
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

        private void orderDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int id = int.Parse(orderDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
                data = new Data();
                string sqlQury = "DELETE FROM TempOrder WHERE Id='" + id+"'";
                int result = data.AllFuntion(sqlQury);
                if (result > 0)
                {
                    LoadOrderDataGV();
                    OrderButtonEnabled();
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void orderButton_Click(object sender, EventArgs e)
        {
            int masterID = 0;
            try
            {
                if (orderDataGridView.Rows.Count > 1)

                {
                    int userID = 0;
                    OrderMaster orderMaster = new OrderMaster();
                    try
                    { 
                        orderMaster.UserID=int.Parse(userIDLabel.Text);
                    }
                    catch(Exception ex) 
                    {
                    }
                    orderMaster.Date = DateTime.Today.Date;
                    orderMaster.OrderID = orderNoLabel.Text;
                    orderMaster.IsGuest = false;
                    try
                    {
                        orderMaster.TotalAmount = decimal.Parse(orderAmountlabel.Text);
                    }
                    catch { }
                    string sql = "Insert into OrderMaster Values('"+orderMaster.UserID+"','"+orderMaster.Date+"','"+orderMaster.TotalAmount+"','"+orderMaster.IsGuest+"','"+orderMaster.OrderID+"')";
                    data = new Data();
                    int result = data.AllFuntion(sql);
                   
                    if (result > 0)
                    {
                        data = new Data();
                        sql = "SELECT ID FROM OrderMaster WHERE OrderID='"+ orderNoLabel.Text + "'";
                        data = new Data();
                        masterID = data.GetIntegerColumnValue(sql);
                    }
                    int detsilsResult = 0;
                    if (masterID > 0)
                    {
                        for (int i = 0; i < orderDataGridView.Rows.Count-1; i++)
                        {
                            OrderDetail orderDetailObj = new OrderDetail();
                            orderDetailObj.OrderID = orderNoLabel.Text;
                            orderDetailObj.MasterID = masterID;
                            orderDetailObj.Category = orderDataGridView.Rows[i].Cells[1].Value.ToString();
                        try
                            {
                                orderDetailObj.ItemID = int.Parse(orderDataGridView.Rows[i].Cells[2].Value.ToString());
                            }
                            catch (Exception ex)
                            {

                            }
                            try
                            {
                                string qnty = orderDataGridView.Rows[i].Cells[4].Value.ToString();
                                orderDetailObj.Quantity = int.Parse(qnty);
                            }
                            catch(Exception ex)
                            {
                                orderDetailObj.Quantity = 0;
                            }
                            try
                            {
                                orderDetailObj.Price = decimal.Parse(orderDataGridView.Rows[i].Cells[5].Value.ToString());
                            }
                            catch (Exception ex)
                            {
                                orderDetailObj.Price = 0;
                            }
                            try
                            {
                                orderDetailObj.Total = decimal.Parse(orderDataGridView.Rows[i].Cells[6].Value.ToString());
                            }
                            catch (Exception ex)
                            {
                                orderDetailObj.Total = 0;
                            }
                            data = new Data();
                            sql = "INSERT INTO OrderDetail VALUES('"+orderDetailObj.OrderID + "','"+orderDetailObj.MasterID + "','"+orderDetailObj.ItemID + "','"+orderDetailObj.Category + "','"+orderDetailObj.Quantity + "','"+orderDetailObj.Price + "','"+orderDetailObj.Total + "')";
                            detsilsResult = data.AllFuntion(sql);
                        }
                        if (detsilsResult > 0)
                        {
                            MessageBox.Show("Order has been placed");
                            DeleteDataFromTempOrder();
                            LoadOrderDataGV();
                            PopulateOrderDT();
                          
                            CreateOrderNo();
                            OrderButtonEnabled();
                          
                        }
                        else
                        {
                        
                            data = new Data();
                            sql = "DELETE FROM OrderMaster WHERE ID='"+ masterID + "' ";
                            int delete = data.AllFuntion(sql);
                            MessageBox.Show("Order has not placed");
                        }
                    }
                }
            }
            catch
            {

            }
        }

     

        private void userToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            UsersForm usersForm = new UsersForm();
            usersForm.Show();
        }

        private void orderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserOrder userOrder = new UserOrder();
            userOrder.Show();
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

        private void label5_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
