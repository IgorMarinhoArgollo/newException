using Tryitter.Domain.Models;
using Tryitter.Infra.Mapping;
using Microsoft.EntityFrameworkCore;

namespace Tryitter.Infra.Context
{
  public class TryitterContext : DbContext
  {
    public TryitterContext(DbContextOptions<TryitterContext> options)
            : base(options)
    { }

    public DbSet<User> Users { get; set; } = null!;
    public DbSet<Post> Posts { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.ApplyConfiguration(new UserMap());
      modelBuilder.ApplyConfiguration(new PostMap());
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      if (!optionsBuilder.IsConfigured)
      {
        optionsBuilder.UseSqlServer(@"
                Server=127.0.0.1;
                Database=my_context_db;
                User=SA;
                Password=Teste123;
            ");
      }
    }

    public override int SaveChanges()
    {
      foreach (var entry in ChangeTracker.Entries().Where(entity => entity.Entity.GetType().GetProperty("DateCreated") != null))
      {
        if (entry.State == EntityState.Added)
        {
          entry.Property("DateCreated").CurrentValue = DateTime.Now;
        }

        if (entry.State == EntityState.Modified)
        {
          entry.Property("DateCreated").IsModified = false;
        }
      }

      return base.SaveChanges();
    }
  }
}

