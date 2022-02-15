using Digisegal.Models;
using Digisegal.Models.Segal_DbContext;
using Digisegal.Repositories.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Digisegal.Repositories
{
    public class AboutUsRepository : Repository<AboutUs>, IAboutUsRepository
    {
        private readonly StoreSegalDbContext _context;
        public AboutUsRepository(StoreSegalDbContext context) : base(context)
        {
            _context = context;
        }
        public StoreSegalDbContext Segl => context as StoreSegalDbContext;
    }
}
