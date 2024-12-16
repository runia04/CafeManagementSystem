using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeManagementSystem.Model
{
    public  class OrderMaster
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public int UserID { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public decimal TotalAmount { get; set; }
        public bool IsGuest { get; set; }
        [Required]
        public string OrderID { get; set; }

    }
}
