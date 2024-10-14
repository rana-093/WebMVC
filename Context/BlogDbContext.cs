using Demo_MVC.Models;
using Microsoft.EntityFrameworkCore;

namespace Demo_MVC.Context;

public class BlogDbContext: DbContext
{
    public BlogDbContext(DbContextOptions<BlogDbContext> options) : base(options) { }
    
    public DbSet<User> Users { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>().HasData(
            new User { Id = 1, Username = "john_doe", Email = "john@example.com", Password = "password123" },
            new User { Id = 2, Username = "jane_doe", Email = "jane@example.com", Password = "password456" }
        );
    }
}