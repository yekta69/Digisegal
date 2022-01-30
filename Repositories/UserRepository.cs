using Digisegal.Models;
using Digisegal.Models.Segal_DbContext;
using Digisegal.Repositories.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Digisegal.Repositories
{
    public class UserRepository : Repository<User> , IUserRepository
    {
       
        private readonly SegalDbContext _context;
        public UserRepository(SegalDbContext context) : base(context)
        {
            _context = context;
        }
        public SegalDbContext Segl => context as SegalDbContext;
    }
}
