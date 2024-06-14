using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Reciepes.Models;

namespace Reciepes.Data
{
    public class ReciepesContext : DbContext
    {
        public ReciepesContext (DbContextOptions<ReciepesContext> options)
            : base(options)
        {
        }

        public DbSet<Reciepes.Models.Reciepe> Reciepe { get; set; } = default!;
    }
}
