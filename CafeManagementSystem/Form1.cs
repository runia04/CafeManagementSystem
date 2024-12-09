using CafeManagementSystem.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
                string query = "Select * From [User] Where Name='" + userName + "'AND  Password='" + password + "'";
               DataSet ds = datObj.Populate(query);
                if (ds.Tables.Count > 0)
                {
                    bool  isAdmin = bool.Parse(ds.Tables[0].Rows[0]["IsAdmin"].ToString());
                    
                    UserOrder userOrderObj = new UserOrder();
                    userOrderObj.Tag =isAdmin;
                    this.Hide();
                    userOrderObj.Show();
                    
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

        }
    }
}
