using CafeManagementSystem.BLL;
using CafeManagementSystem.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace CafeManagementSystem
{
    public partial class UserReport : Form
    {
        Data data = new Data();
        public UserReport()
        {
          
            InitializeComponent();
        }

        private void UserReport_Load(object sender, EventArgs e)
        {
            dateFromTimePicker.Value = DateTime.Today.AddDays(-7);
            dateToTimePicker.Value = DateTime.Today;
            LoadUserCombox();
            bool isDate = false;
            LoadItemGv(isDate);
        }

        private void LoadUserCombox()
        {
           
            string  sqlQuery = "SELECT * FROM   [User]   ";
            DataSet ds = data.Populate(sqlQuery);
            DataTable dt1 = ds.Tables[0];
            DataTable newDT = new DataTable();
            newDT.Columns.Add("Id");
            newDT.Columns.Add("Name");
            DataRow row;
            try
            {
                if (dt1.Rows.Count > 0)
                {
                    row = newDT.NewRow();
                    row["Id"] = 0;
                    row["Name"] = "-Select";
                    newDT.Rows.Add(row);
                    for (int i=0;i< dt1.Rows.Count;i++)
                    {
                        row = newDT.NewRow();
                        row["Id"] = int.Parse(dt1.Rows[i]["Id"].ToString());
                        row["Name"] = dt1.Rows[i]["Name"].ToString();
                        newDT.Rows.Add(row);
                    }
                }
            }
            catch
            {

            }
            userComboBox.DataSource = newDT;
            userComboBox.DisplayMember = "Name";
            userComboBox.ValueMember = "Id";

        }

        private void userComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool isDate = false;
            LoadItemGv(isDate);
        }

        private void userWiseButton_Click(object sender, EventArgs e)
        {
            bool isDate = false;
            LoadItemGv(isDate);
        }

        private void LoadItemGv(bool isDate)
        {
            data = new Data();
            int userID = 0;
            try
            {
                userID =int.Parse( userComboBox.SelectedValue.ToString());
            }
            catch
            {

            }
            string sqlQuery = "SELECT   OrderMaster.UserID,  [User].Name,OrderMaster.Date, OrderMaster.OrderID,OrderMaster.TotalAmount, OrderMaster.IsGuest,OrderMaster.ID FROM  OrderMaster INNER JOIN [User] ON OrderMaster.UserID = [User].Id";
            if (userID != 0)
            {
                sqlQuery = sqlQuery + " " + " WHERE (OrderMaster.UserID = '"+userID+"')";
            }
            if (isDate)
            {
                DateTime dateFrom =dateFromTimePicker.Value;
                DateTime dateTo = dateToTimePicker.Value;
                sqlQuery = sqlQuery + " " + " AND (OrderMaster.Date >='"+dateFrom+ "')  AND (OrderMaster.Date <='"+dateTo+"')";
            }
            DataSet ds = data.Populate(sqlQuery);
            itemDataGridView.DataSource = ds.Tables[0];
            itemDataGridView.AllowUserToAddRows = false;
            try
            {
                if (itemDataGridView.Rows.Count > 0)
                {
                    int rowCount = itemDataGridView.Rows.Count;
                    decimal sumOfTotal = 0;
                    try
                    {
                        for (int i = 0; i < rowCount ; i++)
                        {
                            string value = itemDataGridView.Rows[i].Cells[5].Value.ToString();
                            sumOfTotal += decimal.Parse(value);
                        }
                    }
                    catch
                    {

                    }
                    totalAmountlabel.Text = "Total Amount: ¥"+""+ sumOfTotal.ToString();
                    int count = itemDataGridView.Rows.Count;
                   
                    this.itemDataGridView.Columns["UserID"].Visible = false;
                    this.itemDataGridView.Columns["IsGuest"].Visible = false;
                    this.itemDataGridView.Columns["ID"].Visible = false;
                    this.itemDataGridView.Columns["TotalAmount"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
                    this.itemDataGridView.Columns["TotalAmount"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                }
            }
            catch
            {

            }
                }

        private void userAndDateWiseButton_Click(object sender, EventArgs e)
        {
            bool isDate = true ;
            LoadItemGv(isDate);
        }

        private void itemDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int id = int.Parse(itemDataGridView.Rows[e.RowIndex].Cells[7].Value.ToString());
                DataTable dt = new DataTable();
                dt.Columns.Add("Id");
                dt.Columns.Add("PageName");
                DataRow dr = dt.NewRow();
                dr["Id"] = id;
                dr["PageName"] = "UserReport";
                dt.Rows.Add(dr);

                DetailsView detailsView = new DetailsView();
                detailsView.Tag = dt;
                
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
            e.Graphics.DrawString("====User Sell Report====", new Font("Arial", 17, FontStyle.Bold), Brushes.Black, new Point(170, 85));
            int yPoint = 140;

            e.Graphics.DrawString("Name", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(40, yPoint));
            e.Graphics.DrawString("Date", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(180, yPoint));
            e.Graphics.DrawString("Order ID", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(250, yPoint));
            e.Graphics.DrawString("Total Amount", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(400, yPoint));

            try
            {
                if (itemDataGridView.Rows.Count > 0)
                {
                    for (int i = 0; i < itemDataGridView.Rows.Count ; i++)
                    {
                        DateTime date = DateTime.Parse(itemDataGridView.Rows[i].Cells[3].Value.ToString());

                        yPoint += 40;
                        e.Graphics.DrawString(itemDataGridView.Rows[i].Cells[2].Value.ToString(), new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(40, yPoint));
                        e.Graphics.DrawString(date.ToString("MM/dd/yy"), new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(180, yPoint));
                        e.Graphics.DrawString(itemDataGridView.Rows[i].Cells[4].Value.ToString(), new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(250, yPoint));
                        e.Graphics.DrawString(itemDataGridView.Rows[i].Cells[5].Value.ToString(), new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(400, yPoint));
                    }
                    int rowNo = itemDataGridView.Rows.Count;
                    yPoint += 40;

                    e.Graphics.DrawString("Total: ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(350, yPoint));
                    e.Graphics.DrawString(itemDataGridView.Rows[rowNo - 1].Cells[5].Value.ToString(), new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(400, yPoint));

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
     
        
    

        private void orderToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            UserOrder userOrder = new UserOrder();
            userOrder.Show();
        }

        private void itemsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            ItemsForm itemsForm = new ItemsForm();
            itemsForm.Show();
        }

        private void userToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            UserReport userReport = new UserReport();
            userReport.Show();
        }

        private void orderToolStripMenuItem1_Click_1(object sender, EventArgs e)
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
