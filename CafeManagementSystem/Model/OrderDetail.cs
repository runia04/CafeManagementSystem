using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeManagementSystem.Model
{
    public class OrderDetail
    {
        public int ID { get; set; }
        public string OrderID { get; set; }
        public int MasterID { get; set; }
        public int ItemID { get; set; }
        public string Category { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal Total { get; set; }


    }
}
