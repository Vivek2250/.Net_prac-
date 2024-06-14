using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using day21_calculator.Models;

namespace day21_calculator.Data
{
    public class day21_calculatorContext : DbContext
    {
        public day21_calculatorContext (DbContextOptions<day21_calculatorContext> options)
            : base(options)
        {
        }

        public DbSet<day21_calculator.Models.Controller> Controller { get; set; } = default!;
    }
}
