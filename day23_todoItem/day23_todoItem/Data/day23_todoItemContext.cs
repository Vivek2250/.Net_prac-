using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using day23_todoItem.Models;

namespace day23_todoItem.Data
{
    public class day23_todoItemContext : DbContext
    {
        public day23_todoItemContext (DbContextOptions<day23_todoItemContext> options)
            : base(options)
        {
        }

        public DbSet<day23_todoItem.Models.ToDoItem> ToDoItem { get; set; } = default!;
    }
}
