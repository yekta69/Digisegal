using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Digisegal.Models
{
    public class Product
    {
        public int Id { get; set; }
        public int AmazingOfferId { get; set; }
        public string Title { get; set; }
        public float Amount { get; set; }
        public string AmountType { get; set; }
        public string Description { get; set; }
        public string Brand { get; set; }
        public string Image { get; set; }
        public int Price { get; set; }
    }
}
