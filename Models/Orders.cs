using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Digisegal.Models
{
    public class Orders
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int UserId { get; set; }
        public int PriceOrder { get; set; }
        public string MobileNumber { get; set; }
        public string Address { get; set; }
        public string Type { get; set; }
    }
}
