using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using day23_todoList.Models;

namespace day23_todoList.Data
{
    public class day23_todoListContext : DbContext
    {
        public day23_todoListContext (DbContextOptions<day23_todoListContext> options)
            : base(options)
        {
        }

        public DbSet<day23_todoList.Models.ToDoItem> ToDoItem { get; set; } = default!;
    }
}
