using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using day21_sample2.Models;

namespace day21_sample2.Data
{
    public class day21_sample2Context : DbContext
    {
        public day21_sample2Context (DbContextOptions<day21_sample2Context> options)
            : base(options)
        {
        }

        public DbSet<day21_sample2.Models.Student> Student { get; set; } = default!;
    }
}
