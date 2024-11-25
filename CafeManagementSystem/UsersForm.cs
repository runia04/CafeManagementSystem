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
using CafeManagementSystem.BLL;
namespace CafeManagementSystem
{
    public partial class UsersForm : Form
    {
        Data data = new Data();
        public UsersForm()
        {
            InitializeComponent();
        }

        void populate()
        {
            string query = "select * from [User]";
            DataSet ds = data.Populate(query);
            usersGV.DataSource = ds.Tables[0];
            this.usersGV.Columns["Id"].Visible = false;
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
            string query = "";
            try
            {
                if (phoneNoTextBox.Text == "" || userNameTextBox.Text == "" || passwordTextBox.Text == "")
                {
                    MessageBox.Show("Fillup all the fields.");
                    return;
                }
               
                query = "Insert into [User](Name,Phone,Password)VALUES('" + userNameTextBox.Text + "','" + phoneNoTextBox.Text + "','" + passwordTextBox.Text + "')";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            int rowNo = data.AllFuntion(query);
            if (rowNo > 0)
            {
                MessageBox.Show("User successfully created.");
                populate();
            }
            else
            {
                MessageBox.Show("User not created.");

            }


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
                idTextBox.Text = usersGV.Rows[e.RowIndex].Cells[0].Value.ToString();
                userNameTextBox.Text = usersGV.Rows[e.RowIndex].Cells[1].Value.ToString();
                phoneNoTextBox.Text = usersGV.Rows[e.RowIndex].Cells[2].Value.ToString();
                passwordTextBox.Text = usersGV.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
            catch
            {

            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            //
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (phoneNoTextBox.Text == "" || phoneNoTextBox.Text == null)
            {
                MessageBox.Show("Select the user to be deleted.");
            }
            else
            {
                int id = Convert.ToInt32(idTextBox.Text);
                string query = "Delete From [User] Where Id='"+id+"'";
                int rowNo = data.AllFuntion(query);
                if (rowNo > 0)
                {
                    MessageBox.Show("User deleted successfully.");
                    idTextBox.Text = "";
                    userNameTextBox.Text = "";
                    phoneNoTextBox.Text = "";
                    passwordTextBox.Text = "";
                    populate();
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
                MessageBox.Show("Select the user.");
                return;
            }
            if (phoneNoTextBox.Text == "" || userNameTextBox.Text == ""|| passwordTextBox.Text=="")
            {
                MessageBox.Show("Fillup all the fields.");
            }
            else
            {
                try
                {
                    

                    string query = "Update [User] Set Name='" + userNameTextBox.Text + "',Phone='" + phoneNoTextBox.Text + "',Password='" + passwordTextBox.Text + "' Where Id='" + id + "'";
                    int rowNo = data.AllFuntion(query);
                    if (rowNo > 0)
                    {
                        MessageBox.Show("User updated successfully.");


                        populate();
                    }
                    else
                    {
                        MessageBox.Show("User not updated.");

                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
