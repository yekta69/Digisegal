using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Digisegal.Models
{
    public class Role
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public List<User> UserId { get; set; }
    }
}
