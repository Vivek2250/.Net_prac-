using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Milestone3.Models;

namespace Milestone3.Data
{
    public class Milestone3Context : DbContext
    {
        public Milestone3Context (DbContextOptions<Milestone3Context> options)
            : base(options)
        {
        }

        public DbSet<Milestone3.Models.Task> Task { get; set; } = default!;
    }
}
