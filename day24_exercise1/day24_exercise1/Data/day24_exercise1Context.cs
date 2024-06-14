using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using day24_exercise1.Models;

namespace day24_exercise1.Data
{
    public class day24_exercise1Context : DbContext
    {
        public day24_exercise1Context (DbContextOptions<day24_exercise1Context> options)
            : base(options)
        {
        }

        public DbSet<day24_exercise1.Models.User> User { get; set; } = default!;
    }
}
