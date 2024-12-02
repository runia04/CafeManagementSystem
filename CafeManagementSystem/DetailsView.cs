using CafeManagementSystem.BLL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeManagementSystem
{
    public partial class DetailsView : Form
    {
        Data data = new Data();
        public DetailsView()
        {
            InitializeComponent();
        }

        private void DetailsView_Load(object sender, EventArgs e)
        {
            string value = this.Tag.ToString();
            int id = 0;
            try
            {
                id = int.Parse(value);
                
            }
            catch(Exception ex) {

            }
            string sql = "SELECT OrderMaster.ID, OrderMaster.OrderID, Item.Category, Item.Name, OrderDetail.Quantity, OrderDetail.Price, OrderDetail.Total, OrderMaster.TotalAmount, OrderMaster.Date ";
            sql = sql + " " + "FROM    OrderMaster INNER JOIN   OrderDetail ON OrderMaster.ID = OrderDetail.MasterID AND OrderMaster.OrderID = OrderDetail.OrderID INNER JOIN  Item ON OrderDetail.ItemID = Item.Id WHERE OrderMaster.ID='"+id+"'";
            DataSet ds = data.Populate(sql);
            int rowNo = 0;
            decimal totalAmount = 0;
            try
            {
                if (ds.Tables.Count > 0)
                {
                    DateTime date = DateTime.Parse(ds.Tables[0].Rows[0]["Date"].ToString());
                    string orderID = ds.Tables[0].Rows[0]["OrderID"].ToString();
                    dateLabel.Text = date.ToString("MM/dd/yy");
                    orderIDlabel.Text = orderID;
                    totalAmount = decimal.Parse(ds.Tables[0].Rows[0]["TotalAmount"].ToString());
                     rowNo = ds.Tables.Count;
                   
                  //  ds.Tables[0].Rows[rowNo]["Total"] = totalAmount.ToString();

                   // itemDataGridView.Rows.Add(null, null, null, null, null, null, "Total: ", totalAmount);
                }
            }
            catch
            {

            }
                    itemDataGridView.DataSource = ds.Tables[0];
           // itemDataGridView.Rows.Add(null, null, null, null, null, null, "Total: ", totalAmount);
            // itemDataGridView.AllowUserToAddRows = false;
            this.itemDataGridView.Columns["ID"].Visible = false;
            this.itemDataGridView.Columns["OrderID"].Visible = false;
            this.itemDataGridView.Columns["TotalAmount"].Visible = false;
            this.itemDataGridView.Columns["Date"].Visible = false;
            this.itemDataGridView.Rows[rowNo + 1].Cells[5].Value = "Total: "; ;
            this. itemDataGridView.Rows[rowNo+1].Cells[6].Value = totalAmount.ToString(); ;
            this.itemDataGridView.Columns["Total"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.itemDataGridView.Columns["Total"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            ViewOrderList viewOrderList = new ViewOrderList();
            viewOrderList.Show();
            this.Hide();
        }

        
    }
}
