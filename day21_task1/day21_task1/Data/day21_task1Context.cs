using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using day21_task1.Models;

namespace day21_task1.Data
{
    public class day21_task1Context : DbContext
    {
        public day21_task1Context (DbContextOptions<day21_task1Context> options)
            : base(options)
        {
        }

        public DbSet<day21_task1.Models.Calculator> Calculator { get; set; } = default!;
    }
}
