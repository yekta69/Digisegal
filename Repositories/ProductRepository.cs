using Digisegal.Models;
using Digisegal.Models.Segal_DbContext;
using Digisegal.Repositories.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Digisegal.Repositories
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private readonly StoreSegalDbContext _context;
        public ProductRepository(StoreSegalDbContext context) : base(context)
        {
            _context = context;
        }
        public StoreSegalDbContext Segl => context as StoreSegalDbContext;
    }
}
