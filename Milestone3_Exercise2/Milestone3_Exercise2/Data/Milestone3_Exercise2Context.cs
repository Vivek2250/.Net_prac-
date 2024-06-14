using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Milestone3_Exercise2.Models;

namespace Milestone3_Exercise2.Data
{
    public class Milestone3_Exercise2Context : DbContext
    {
        public Milestone3_Exercise2Context (DbContextOptions<Milestone3_Exercise2Context> options)
            : base(options)
        {
        }

        public DbSet<Milestone3_Exercise2.Models.Ticket> Ticket { get; set; } = default!;

        public DbSet<Milestone3_Exercise2.Models.User> User { get; set; } = default!;
    }
}
