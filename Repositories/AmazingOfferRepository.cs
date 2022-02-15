using Digisegal.Models;
using Digisegal.Models.Segal_DbContext;
using Digisegal.Repositories.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Digisegal.Repositories
{
    public class AmazingOfferRepository : Repository<AmazingOffer>, IAmazingOfferRepository
    {
        private readonly StoreSegalDbContext _context;
        public AmazingOfferRepository(StoreSegalDbContext context) : base(context)
        {
            _context = context;
        }
        public StoreSegalDbContext Segl => context as StoreSegalDbContext;
    }
}
