using Microsoft.EntityFrameworkCore;
using StudentManagementSystem.Models;
namespace StudentManagementSystem.Data;


public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Student> Students { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        // any fluent config goes here (indexes, constraints)
        modelBuilder.Entity<Student>().HasIndex(s => s.RollNo).IsUnique();
    }
}
