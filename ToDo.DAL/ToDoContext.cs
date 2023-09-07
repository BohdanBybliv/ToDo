using Microsoft.EntityFrameworkCore;
using ToDo.DAL.Entities;

namespace ToDo.DAL
{
    public class ToDoContext : DbContext
    {
        public DbSet<Issue> Issues { get; set; }
        public ToDoContext(DbContextOptions<ToDoContext> options) : base(options) { }
    }
}
