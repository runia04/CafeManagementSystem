using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
namespace CafeManagementSystem.BLL
{
    public  class Data
    {
        SqlConnection con = new SqlConnection(@"Data Source=MONIRUL;Initial Catalog=CafeDB;Integrated Security=True;TrustServerCertificate=True");
        public int AllFuntion(string query)
        {
            //try
            //{
            //    con.Close();
            //    con.Open();
            //    SqlCommand cmd = new SqlCommand(query, con);
            //    int rowNo = cmd.ExecuteNonQuery();

            //    con.Close();
            //    return rowNo;
            //}
            //catch (Exception ex)
            //{
            //    return 0; 
            //}
            return 1;
        }
        public DataSet Populate(string query)
        {
            con.Open();
            
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
           
            con.Close();
            return ds;
        }
      
    }
}
