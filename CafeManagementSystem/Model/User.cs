using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CafeManagementSystem.Model
{
    public class User
    {
        public int Id { get; set; }
       
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Passwor { get; set; }
        public bool IsLoggedIn { get; set; }
        public bool IsAdmin { get; set; }

    }
}
