using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using day19_WebApplication7.Models;

namespace day19_WebApplication7.Data
{
    public class day19_WebApplication7Context : DbContext
    {
        public day19_WebApplication7Context (DbContextOptions<day19_WebApplication7Context> options)
            : base(options)
        {
        }

        public DbSet<day19_WebApplication7.Models.Library> Library { get; set; } = default!;

        public DbSet<day19_WebApplication7.Models.Book> Book { get; set; } = default!;
    }
}
