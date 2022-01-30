using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Digisegal.Models.Segal_DbContext
{
    public class SegalDbContext:DbContext
    {

        public SegalDbContext(DbContextOptions<SegalDbContext> options)
            : base(options)
        {

        }
        public virtual DbSet<User> Users { get; set; }
        
    }
   
}
