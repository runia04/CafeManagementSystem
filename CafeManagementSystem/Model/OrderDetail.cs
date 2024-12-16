using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeManagementSystem.Model
{
    public class OrderDetail
    {
        [Required]
        public int ID { get; set; }
        [Required]
        public string OrderID { get; set; }
        [Required]
        public int MasterID { get; set; }
        [Required]
        public int ItemID { get; set; }
        [Required]
        public string Category { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public decimal Total { get; set; }


    }
}
