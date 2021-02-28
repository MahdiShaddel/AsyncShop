using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VenderConvention.Models;

namespace VenderConvention.Contexts
{
    public class ShopContext:DbContext
    {
        public ShopContext(DbContextOptions options):base(options)
        {
            

        }

       
        public DbSet<vendor> Vendor { get; set; }
        public DbSet<Tag> Tag { get; set; }
        
    }
}
