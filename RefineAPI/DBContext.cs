using Microsoft.EntityFrameworkCore;
using RefineAPI.Models;

namespace RefineAPI
{
    public class DBContext : DbContext
    {
        public DBContext()
        {
        }

        public DBContext(DbContextOptions<DBContext> options) : base(options)
        {
        }
        public DbSet<RefineAPI.Models.Category> Category { get; set; } = default!;
        public DbSet<RefineAPI.Models.Product> Product { get; set; } = default!;
        public DbSet<RefineAPI.Models.BlogPost> BlogPost { get; set; } = default!;

        // Define your DbSet properties for each entity in your database
        // For example:
        // public DbSet<User> Users { get; set; }
        // public DbSet<Order> Orders { get; set; }

        // Add other configurations, such as overriding OnModelCreating if needed
    }
}