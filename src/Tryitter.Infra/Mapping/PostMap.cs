using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tryitter.Domain.Models;

namespace Tryitter.Infra.Mapping
{
    public class PostMap : IEntityTypeConfiguration<Post>
    {
        public void Configure(EntityTypeBuilder<Post> builder)
        {
            builder.ToTable("Post", "dbo");

            builder.HasKey(post => post.Id);

            builder.Property(post => post.Title)
                .HasColumnType("VARCHAR(120)")
                .HasMaxLength(120)
                .IsRequired();

            builder.Property(post => post.Text)
                .HasColumnType("VARCHAR(120)")
                .HasMaxLength(120)
                .IsRequired();

            builder.Property(post => post.Image)
                .HasColumnType("VARCHAR(500)")
                .HasMaxLength(500);

            builder.Property(post => post.CreatedAt)
                .HasColumnType("DATETIME2")
                .IsRequired();

                builder.Property(post => post.UpdatedAt)
                .HasColumnType("DATETIME2")
                .IsRequired();

            builder.HasOne(post => post.User)
                .WithMany(user => user.Posts)
                .OnDelete(DeleteBehavior.SetNull);
        }
    }
}