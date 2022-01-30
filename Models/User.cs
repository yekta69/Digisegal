using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Digisegal.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string LastName { get; set; }
        public string Nationalcode { get; set; }
        public string  Password { get; set; }
        public DateTime RegisteryDate { get; set; }
        public string Role { get; set; }
        public string MobileNumber { get; set; }
        public bool IsDelete { get; set; }
        public  string Email { get; set; }
        public string Image { get; set; }



    }
}
