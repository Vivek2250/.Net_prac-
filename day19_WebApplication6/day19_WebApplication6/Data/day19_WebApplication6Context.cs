using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using day19_WebApplication6.Models;

namespace day19_WebApplication6.Data
{
    public class day19_WebApplication6Context : DbContext
    {
        public day19_WebApplication6Context (DbContextOptions<day19_WebApplication6Context> options)
            : base(options)
        {
        }

        public DbSet<day19_WebApplication6.Models.Student> Student { get; set; } = default!;
    }
}
