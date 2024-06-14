using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using day21_sample3.Models;

namespace day21_sample3.Data
{
    public class day21_sample3Context : DbContext
    {
        public day21_sample3Context (DbContextOptions<day21_sample3Context> options)
            : base(options)
        {
        }

        public DbSet<day21_sample3.Models.Account> Account { get; set; } = default!;
    }
}
