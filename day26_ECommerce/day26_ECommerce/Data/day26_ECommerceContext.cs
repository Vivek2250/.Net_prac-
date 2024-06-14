using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using day26_ECommerce.Models;

namespace day26_ECommerce.Data
{
    public class day26_ECommerceContext : DbContext
    {
        public day26_ECommerceContext (DbContextOptions<day26_ECommerceContext> options)
            : base(options)
        {
        }

        public DbSet<day26_ECommerce.Models.Product> Product { get; set; } = default!;
    }
}
