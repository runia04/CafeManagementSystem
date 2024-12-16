using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CafeManagementSystem.Model
{
    public  class TempOrder
    {
        [Key]
        public int Id { get; set; }
       
        public string Category { get; set; }
        public int ItemId { get; set; }
        public string ItemName { get; set;}
        public int Qunatity { get; set; }
        public decimal Price { get; set; }
        public decimal TotalPrice { get; set; }
        public bool IsUser { get; set; }

    }
}
