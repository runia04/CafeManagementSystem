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
using System.Security.Cryptography;
using System.IO;
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
       
        static string Encrypt(string value)
        {
            string EncryptionKey = "MAKV2SPBNI99212";
            byte[] clearBytes = Encoding.Unicode.GetBytes(value);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(clearBytes, 0, clearBytes.Length);
                        cs.Close();
                    }
                    value = Convert.ToBase64String(ms.ToArray());
                }
            }
            return value;
           
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
                string pass = passwordTextBox.Text;
                string password = Encrypt(pass);
                query = "Insert into [User](Name,Phone,Password,IsLoggedIn,IsAdmin)VALUES('" + userNameTextBox.Text + "','" + phoneNoTextBox.Text + "','" + password + "','false','"+isAdminCheckBox.Checked+"')";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            int rowNo = data.AllFuntion(query);
            if (rowNo > 0)
            {
                MessageBox.Show("User successfully created.");
                idTextBox.Text = "";
                userNameTextBox.Text = "";
                phoneNoTextBox.Text = "";
                passwordTextBox.Text = "";
                isAdminCheckBox.Checked = false;
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
            passwordTextBox.PasswordChar = '*';
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
                isAdminCheckBox.Checked = bool.Parse(usersGV.Rows[e.RowIndex].Cells[5].Value.ToString());
                this.usersGV.Columns["IsLoggedIn"].Visible = false;
                this.usersGV.Columns["Password"].Visible = false;
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
                    isAdminCheckBox.Checked = false;
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
                    string pass = passwordTextBox.Text;
                    string password = Encrypt(pass);
                    string query = "Update [User] Set Name='" + userNameTextBox.Text + "',Phone='" + phoneNoTextBox.Text + "',Password='" + password + "',IsAdmin='" + isAdminCheckBox.Checked + "' Where Id='" + id + "'";
                    int rowNo = data.AllFuntion(query);
                    if (rowNo > 0)
                    {
                        MessageBox.Show("User updated successfully.");

                        idTextBox.Text = "";
                        userNameTextBox.Text = "";
                        phoneNoTextBox.Text = "";
                        passwordTextBox.Text = "";
                        isAdminCheckBox.Checked = false;
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

        private void closeLabel_Click(object sender, EventArgs e)
        {

        }

      

        private void button1_Click(object sender, EventArgs e)
        {

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
