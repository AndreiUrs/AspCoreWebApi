using Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Entities;

internal class RepositoryContext : DbContext
{
    private DbContextOptionsBuilder optionsBuilder;

    public RepositoryContext(DbContextOptions options) : base(options) { }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(RepositoryContext).Assembly);
    }

    public DbSet<Company> Companies { get; set; }
    public DbSet<Employee> Employees { get; set; }
}
