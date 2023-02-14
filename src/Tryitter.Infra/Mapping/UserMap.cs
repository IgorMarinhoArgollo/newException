using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tryitter.Domain.Models;

namespace Tryitter.Infra.Mapping
{
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("User", "dbo");

            builder.HasKey(user => user.Id);

            builder.Property(user => user.Name)
                .HasColumnType("VARCHAR(120)")
                .HasMaxLength(120)
                .IsRequired();

            builder.Property(user => user.Email)
                .HasColumnType("VARCHAR(120)")
                .HasMaxLength(120)
                .IsRequired();

            builder.Property(user => user.Password)
                .HasColumnType("VARCHAR(30)")
                .HasMaxLength(30)
                .IsRequired();

            builder.Property(user => user.CreatedAt)
                .HasColumnType("DATETIME2")
                .IsRequired();

                builder.Property(user => user.UpdatedAt)
                .HasColumnType("DATETIME2")
                .IsRequired();

            builder.HasMany(user => user.Posts)
                .WithOne(post => post.User)
                .OnDelete(DeleteBehavior.SetNull);
        }
    }
}