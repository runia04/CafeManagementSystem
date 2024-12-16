using CafeManagementSystem.BLL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CafeManagementSystem
{
    public partial class Form1 : Form
    {
        Data datObj = new Data();
        public Form1()
        {
            InitializeComponent();
        }

       

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
      
        }

        private void label4_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //GuestOrder guest = new GuestOrder();
            //guest.Show();
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

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (userNameTextBox.Text == "" || passwordTextBox.Text == "")
            {
                MessageBox.Show("Fillup all the fields.");
            }
            else
            {
                string userName = userNameTextBox.Text;
                ;
                string password = passwordTextBox.Text;

                string encryptValue = Encrypt(password);
                string query = "Select * From [User] Where Name='" + userName + "'AND  Password='" + encryptValue + "'";
               DataSet ds = datObj.Populate(query);
                if (ds.Tables.Count > 0)
                {
                    bool isAdmin = false;
                    try
                    {
                        int id = int.Parse(ds.Tables[0].Rows[0]["Id"].ToString());
                        string sqlQuery = "UPDATE [User]Set IsLoggedIn='true' WHERE Id='"+id+"' ";
                        int rowNo = datObj.AllFuntion(sqlQuery);
                        isAdmin = bool.Parse(ds.Tables[0].Rows[0]["IsAdmin"].ToString());

                        UserOrder userOrderObj = new UserOrder();
                        userOrderObj.Tag = isAdmin;
                        this.Hide();
                        userOrderObj.Show();
                    }
                    catch
                    {
                        MessageBox.Show("User not found.");
                    }
                    
                }
                else
                {
                    MessageBox.Show("User not found.");
                }
            }
            
            
          
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            #region check admin exist;if admin not exit creat admin
            string sqlQuery = "";
            try
            {
                 sqlQuery = "Select * From [User] Where Name='admin'";
                DataSet ds = datObj.Populate(sqlQuery);
                if (ds.Tables[0].Rows.Count == 0)
                {
                    string password= Encrypt("1234");
                    sqlQuery = "Insert into [User](Name,Phone,Password,IsLoggedIn,IsAdmin)VALUES('admin','','" + password + "','false','true')";
                    int rowNo = datObj.AllFuntion(sqlQuery);
                }
            }
            catch
            {

            }
        #endregion
            try
            {
                 sqlQuery = "UPDATE [User]Set IsLoggedIn='false' ";
                int rowNo = datObj.AllFuntion(sqlQuery);
            }
            catch
            {

            }
            passwordTextBox.PasswordChar = '*';
        }
    }
}
