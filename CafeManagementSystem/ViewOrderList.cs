using CafeManagementSystem.BLL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CafeManagementSystem
{
    public partial class ViewOrderList : Form
    {
        Data data = new Data();
        public ViewOrderList()
        {
            InitializeComponent();
        }

        private void ViewOrderList_Load(object sender, EventArgs e)
        {
            dateFromTimePicker.Value = DateTime.Today.AddDays(-7);
            dateToTimePicker.Value = DateTime.Today;
            ShowDateWiseOrderList();
        }

        private void ShowDateWiseOrderList()
        {
            DateTime fromDate = dateFromTimePicker.Value;
            DateTime toDate = dateToTimePicker.Value;
            string sql = "SELECT [User].Name AS UserName, [User].Phone, [User].Password, [User].IsLoggedIn, OrderMaster.ID AS ID, OrderMaster.UserID, OrderMaster.Date, OrderMaster.TotalAmount, OrderMaster.IsGuest, OrderMaster.OrderID FROM   OrderMaster INNER JOIN  [User] ON OrderMaster.UserID = [User].Id   WHERE( OrderMaster.Date>='"+fromDate+"' AND  OrderMaster.Date<='"+toDate+"' )";
         
            DataSet ds = data.Populate(sql);
            try
            {
                if (ds.Tables.Count > 0)
                {
                 
                    decimal sumOfTotal = 0;
                    DataTable dtFirst = new DataTable();
                    dtFirst.Columns.Add("ID");
                    dtFirst.Columns.Add("OrderID");
                    dtFirst.Columns.Add("UserName");
                    dtFirst.Columns.Add("Date");
                    dtFirst.Columns.Add("TotalAmount");
                    DataRow newRow;
                    for (int i = 0; i < ds.Tables.Count; i++) {
                        int id = int.Parse(ds.Tables[0].Rows[i]["ID"].ToString());
                        string orderID = ds.Tables[0].Rows[i]["OrderID"].ToString();
                        string userName = ds.Tables[0].Rows[i]["UserName"].ToString();
                        DateTime date = DateTime.Parse(ds.Tables[0].Rows[i]["Date"].ToString());
                        decimal total = decimal.Parse(ds.Tables[0].Rows[i]["TotalAmount"].ToString());
                        sumOfTotal += total;
                        newRow = dtFirst.Rows.Add();
                        newRow.SetField("ID", id);
                        newRow.SetField("OrderID", orderID);
                        newRow.SetField("UserName", userName);
                        newRow.SetField("Date", date.ToString("MM/dd/yy"));
                        newRow.SetField("TotalAmount",total);
                    }
                    itemDataGridView.DataSource = dtFirst;
                    totalAmountlabel.Text = sumOfTotal.ToString();
                    itemDataGridView.AllowUserToAddRows = false;
                    this.itemDataGridView.Columns["orderID"].ReadOnly = true;
                    this.itemDataGridView.Columns["UserName"].ReadOnly = true;
                    this.itemDataGridView.Columns["Date"].ReadOnly = true;
                    this.itemDataGridView.Columns["TotalAmount"].ReadOnly = true;
                  
                    this.itemDataGridView.Columns["ID"].Visible = false;
                    this.itemDataGridView.Columns["TotalAmount"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
                    this.itemDataGridView.Columns["TotalAmount"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                }

            }
            catch
            {

            }
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ShowDateWiseOrderList();
        }

        private void itemDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                int  id = int.Parse(itemDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString());
                
                DetailsView detailsView = new DetailsView();
                detailsView.Tag = id;
                detailsView.Show();
                this.Hide();
               
            }
            catch (Exception ex)
            {

            }
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
                printDocument1.Print();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("========Cafe Software=======", new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(170, 40));
            e.Graphics.DrawString("======Order List======", new Font("Arial", 17, FontStyle.Bold), Brushes.Black, new Point(170, 85));
            int yPoint = 120;
            e.Graphics.DrawString("Date From:", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new Point(10, yPoint));
            e.Graphics.DrawString(dateFromTimePicker.Value.ToString("MM/dd/yy"), new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(150, yPoint));
            e.Graphics.DrawString("To:", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new Point(300, yPoint));
            e.Graphics.DrawString(dateToTimePicker.Value.ToString("MM/dd/yy"), new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(400, yPoint));
            yPoint += 40;
            e.Graphics.DrawString("orderID", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(10, yPoint));
            e.Graphics.DrawString("User Name", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(200, yPoint));
            e.Graphics.DrawString("Date", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(550, yPoint));
            e.Graphics.DrawString("Total Amount", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(700, yPoint));
            try
            {
                if (itemDataGridView.Rows.Count > 0)
                {
                    for(int i=0;i< itemDataGridView.Rows.Count; i++)
                    {
                        yPoint += 40;
                        e.Graphics.DrawString(itemDataGridView.Rows[i].Cells[2].Value.ToString(), new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(10, yPoint));
                        e.Graphics.DrawString(itemDataGridView.Rows[i].Cells[3].Value.ToString(), new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(200, yPoint));
                        e.Graphics.DrawString(itemDataGridView.Rows[i].Cells[4].Value.ToString(), new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(550, yPoint));
                        e.Graphics.DrawString(itemDataGridView.Rows[i].Cells[5].Value.ToString(), new Font("Arial", 11, FontStyle.Bold), Brushes.Black,new Point(700, yPoint));

                    }
                }
            }
            catch
            {

            }

        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
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
    }
}
