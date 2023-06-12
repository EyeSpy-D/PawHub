using Microsoft.EntityFrameworkCore;
using PawHubAPI.Models;

namespace PawHubAPI.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }
    
    public DbSet<User> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>().HasData(
            new User()
            {
                Id = 1,
                Email = "test01gmail.com",
                Password = "password01",
                Time = DateTime.Now
            },
            new User()
            {
                Id = 2,
                Email = "test02gmail.com",
                Password = "password02",
                Time = DateTime.Now
            });
    }
}