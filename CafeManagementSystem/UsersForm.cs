using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace CafeManagementSystem
{
    public partial class UsersForm : Form
    {
        public UsersForm()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=MONIRUL;Initial Catalog=CafeDB;Integrated Security=True;TrustServerCertificate=True");
      
        void populate()
        {
            con.Open();
            string query = "select Name,Phone,Password from [User]";
            SqlDataAdapter sda = new SqlDataAdapter(query,con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            usersGV.DataSource = ds.Tables[0];
            con.Close();
        }
        private void orderButton_Click(object sender, EventArgs e)
        {
            UserOrder userOrder = new UserOrder();
            userOrder.Show();
        }

        private void itemsButton_Click(object sender, EventArgs e)
        {
            ItemsForm itemsForm = new ItemsForm();
            itemsForm.Show();
            this.Hide();
        }

        private void logoutLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.Show();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            string query = "";
            try
            {
                query = "Insert into [User](Name,Phone,Password)VALUES('" + userNameTextBox.Text + "','" + phoneNoTextBox.Text + "','" + passwordTextBox.Text + "')";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            SqlCommand cmd = new SqlCommand(query, con);
           int rowNo= cmd.ExecuteNonQuery();
            MessageBox.Show("User successfully created.");
            con.Close();
            populate();
        }

        private void userNameTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void UsersForm_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void usersGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
               
                userNameTextBox.Text= usersGV.Rows[e.RowIndex].Cells[0].Value.ToString();
                phoneNoTextBox.Text = usersGV.Rows[e.RowIndex].Cells[1].Value.ToString();
                passwordTextBox.Text = usersGV.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
            catch
            {

            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            //https://youtu.be/HR7Pd73BxbI?list=PLBpH5WxSM4d3tXXlS1hQLztvfVPqgwxB2&t=4760
        }
    }
}
