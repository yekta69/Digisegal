using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Digisegal.Models
{
    public class AmazingOffer
    {
        public int Id { get; set; }
        public List<Product> ProductId { get; set; }
        public string Title { get; set; }
        public string Image { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }
    }
}
