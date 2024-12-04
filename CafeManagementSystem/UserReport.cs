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
            LoadUserCombox();
        }

        private void LoadUserCombox()
        {
            int userID = 0;
            try
            {
                if (userComboBox.SelectedIndex != -1)
                {
                    userID = userComboBox.SelectedIndex;
                }
            }
            catch (Exception ex)
            {

            }
            string sqlQuery = "";
            if (userID == 0)
            {
                sqlQuery = "SELECT * FROM   [User]   ";
            }
            else
            {
                sqlQuery = "SELECT * FROM   [User]  WHERE (Id = '" + userID + "') ";
                
            }
            DataSet ds = data.Populate(sqlQuery);
            userComboBox.DataSource = ds.Tables[0];
           
            userComboBox.DisplayMember = "Name";
            userComboBox.ValueMember = "Id";
            //cmbCompName.DataBind();
            //userComboBox.Enabled = true;
        }
    }
}
