using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Milestone3_Exercise1.Models;

namespace Milestone3_Exercise1.Data
{
    public class Milestone3_Exercise1Context : DbContext
    {
        public Milestone3_Exercise1Context (DbContextOptions<Milestone3_Exercise1Context> options)
            : base(options)
        {
        }

        public DbSet<Milestone3_Exercise1.Models.TaskManagement> TaskManagement { get; set; } = default!;
    }
}
