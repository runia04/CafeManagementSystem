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
           
            DataTable newDT= (DataTable)(this.Tag);
            int id = 0;
            string  pageName = "";
            try
            {
                id = int.Parse(newDT.Rows[0]["Id"].ToString());
                idlabel.Text = id.ToString();
            }
            catch
            {

            }
            try
            {
                pageName = newDT.Rows[0]["PageName"].ToString();
                pageNamelabel.Text = pageName;
            }
            catch
            {

            }
            string sql = "SELECT  OrderMaster.ID, OrderMaster.OrderID,[User].Name AS UserName , Item.Category, Item.Name, OrderDetail.Quantity, OrderDetail.Price, OrderDetail.Total, OrderMaster.TotalAmount, OrderMaster.Date";
            sql = sql + " " + "FROM     OrderMaster INNER JOIN OrderDetail ON OrderMaster.ID = OrderDetail.MasterID AND OrderMaster.OrderID = OrderDetail.OrderID INNER JOIN   Item ON OrderDetail.ItemID = Item.Id INNER JOIN [User] ON OrderMaster.UserID = [User].Id WHERE OrderMaster.ID='" + id+"'";
            DataSet ds = data.Populate(sql);
            int rowNo = 0;
            decimal totalAmount = 0;
            try
            {
                if (ds.Tables[0].Rows.Count > 0)
                {
                    DateTime date = DateTime.Parse(ds.Tables[0].Rows[0]["Date"].ToString());
                    string orderID = ds.Tables[0].Rows[0]["OrderID"].ToString();
                    dateLabel.Text = date.ToString("MM/dd/yy");
                    orderIDlabel.Text = orderID;
                    totalAmount = decimal.Parse(ds.Tables[0].Rows[0]["TotalAmount"].ToString());
                    rowNo = ds.Tables.Count;
                }
            }
            catch
            {

            }
            itemDataGridView.DataSource = ds.Tables[0];
            itemDataGridView.AllowUserToAddRows = false;
            this.itemDataGridView.Columns["ID"].Visible = false;
            this.itemDataGridView.Columns["OrderID"].Visible = false;
            this.itemDataGridView.Columns["TotalAmount"].Visible = false;
            this.itemDataGridView.Columns["Date"].Visible = false;
            totalAmountlabel.Text = "¥"+""+ totalAmount.ToString();



        }

        private void backButton_Click(object sender, EventArgs e)
        {
          string pageName=  pageNamelabel.Text;
            if (pageName == "ViewOrderList")
            {
                ViewOrderList viewOrderList = new ViewOrderList();
                viewOrderList.Show();
            }
            else
            {
                UserReport userReport = new UserReport();
                userReport.Show();
            }
            
            this.Hide();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            e.Graphics.DrawString("========Cafe Software=======", new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(170, 40));
            e.Graphics.DrawString("======Order Details======",new Font("Arial",17,FontStyle.Bold),Brushes.Black, new Point(170,85));
            int yPoint = 120;
            e.Graphics.DrawString("Category", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(10, yPoint));

            e.Graphics.DrawString("Name", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(220, yPoint));
           e.Graphics.DrawString("Qnt.", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(380, yPoint));
           e.Graphics.DrawString("Price", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(550, yPoint));
           e.Graphics.DrawString("Total", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(700, yPoint));
            
            try
            {
                if (itemDataGridView.Rows.Count > 0)
                {
                    for (int i=0;i<itemDataGridView.Rows.Count-1;i++)
                    {
                        yPoint += 40;
                        e.Graphics.DrawString(itemDataGridView.Rows[i].Cells[2].Value.ToString(), new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(10, yPoint));
                        e.Graphics.DrawString(itemDataGridView.Rows[i].Cells[3].Value.ToString(), new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(220, yPoint));
                        e.Graphics.DrawString(itemDataGridView.Rows[i].Cells[4].Value.ToString(), new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(380, yPoint));
                        e.Graphics.DrawString(itemDataGridView.Rows[i].Cells[5].Value.ToString(), new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(550, yPoint));
                        e.Graphics.DrawString(itemDataGridView.Rows[i].Cells[6].Value.ToString(), new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(700, yPoint));
                    }
                    int rowNo = itemDataGridView.Rows.Count;
                    yPoint += 40;

                    e.Graphics.DrawString("Total ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(550, yPoint));
                    e.Graphics.DrawString(itemDataGridView.Rows[rowNo-1].Cells[6].Value.ToString(), new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(700, yPoint));

                }
            }
            catch
            {

            }
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
                printDocument1.Print();
        }
    }
}
