using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Calling_Backend.Models;

namespace Calling_Backend.Data
{
    public class Calling_BackendContext : DbContext
    {
        public Calling_BackendContext (DbContextOptions<Calling_BackendContext> options)
            : base(options)
        {
        }

        public DbSet<Calling_Backend.Models.student> student { get; set; } = default!;
    }
}
