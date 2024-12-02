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
                    DataTable dtFirst = new DataTable();
                    dtFirst.Columns.Add("ID");
                    dtFirst.Columns.Add("OrderID");
                    dtFirst.Columns.Add("UserName");
                    dtFirst.Columns.Add("Date");
                    dtFirst.Columns.Add("TotalAmount");
                    for (int i = 0; i < ds.Tables.Count; i++) {
                        int id = int.Parse(ds.Tables[0].Rows[i]["ID"].ToString());
                        string orderID = ds.Tables[0].Rows[i]["OrderID"].ToString();
                        string userName = ds.Tables[0].Rows[i]["UserName"].ToString();
                        DateTime date = DateTime.Parse(ds.Tables[0].Rows[i]["Date"].ToString());
                        decimal total = decimal.Parse(ds.Tables[0].Rows[i]["TotalAmount"].ToString());
                        DataRow newRow = dtFirst.Rows.Add();
                        newRow.SetField("ID", id);
                        newRow.SetField("OrderID", orderID);
                        newRow.SetField("UserName", userName);
                        newRow.SetField("Date", date.ToString("mm/dd/yy"));
                        newRow.SetField("TotalAmount",total);
                    }
                    itemDataGridView.DataSource = dtFirst;
                    itemDataGridView.AllowUserToAddRows = false;
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
    }
}
