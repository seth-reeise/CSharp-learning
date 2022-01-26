/*
 * A database context is the main class that coordinates Entity Framework functionality for a data model
 * Derives from Microsoft.EntityFrameworkCore.DbContext class
 */

using Microsoft.EntityFrameworkCore;

namespace TodoApi.Models
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options)
            : base(options)
        {
        }
        public DbSet<TodoItem> TodoItems { get; set; }
    }
}