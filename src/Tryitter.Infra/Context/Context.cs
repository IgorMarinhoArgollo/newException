using Tryitter.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Tryitter.Infra.Context
{
  public class TryitterContext : DbContext
  {
    public TryitterContext(DbContextOptions<TryitterContext> options)
    : base(options) { }

    public DbSet<User> Users { get; set; } = null!;
    public DbSet<Post> Posts { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      // keys
      modelBuilder.Entity<Post>()
      .HasKey(post => post.Id);

      modelBuilder.Entity<User>()
      .HasKey(user => user.Id);

      // Properties
        // Posts
      modelBuilder.Entity<Post>()
      .Property(post => post.Title)
                .HasColumnType("VARCHAR(120)")
                .HasMaxLength(120)
                .IsRequired();
      modelBuilder.Entity<Post>()
      .Property(post => post.Text)
                .HasColumnType("VARCHAR(120)")
                .HasMaxLength(120)
                .IsRequired();

      modelBuilder.Entity<Post>()
      .Property(post => post.Image)
                .HasColumnType("VARCHAR(500)")
                .HasMaxLength(500);

        // Users
      modelBuilder.Entity<User>()
      .Property(user => user.Name)
                .HasColumnType("VARCHAR(120)")
                .HasMaxLength(120)
                .IsRequired();

      modelBuilder.Entity<User>()
      .Property(user => user.Email)
                .HasColumnType("VARCHAR(120)")
                .HasMaxLength(120)
                .IsRequired();

      modelBuilder.Entity<User>()
      .Property(user => user.Password)
          .HasColumnType("VARCHAR(30)")
          .HasMaxLength(30)
          .IsRequired();

      // Relations
      modelBuilder.Entity<User>()
          .HasMany(user => user.Posts)
          .WithOne(post => post.user)
          .HasForeignKey(post => post.UserId);
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      if (!optionsBuilder.IsConfigured)
      {
        optionsBuilder.UseSqlServer(@"
                Server=127.0.0.1;
                Database=Tryitter;
                User=SA;
                Password=Teste123;
            ");
      }
    }


  }
}

