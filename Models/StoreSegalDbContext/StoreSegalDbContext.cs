using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Digisegal.Models.Segal_DbContext
{
    public class StoreSegalDbContext:DbContext
    {
        public StoreSegalDbContext(DbContextOptions<StoreSegalDbContext> options)
            : base(options)
        {

        }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Organ> Organs { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<ContactUs> ContactUs { get; set; }
        public virtual DbSet<AmazingOffer> AmazingOffers { get; set; }
        public virtual DbSet<AboutUs> AboutUs { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
    }
   
}
