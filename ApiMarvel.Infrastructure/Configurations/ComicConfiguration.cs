using ApiMarvel.Domain.Models.Comics;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ApiMarvel.Infrastructure.Configurations;

public class ComicConfiguration : IEntityTypeConfiguration<Comic>
{
    public void Configure(EntityTypeBuilder<Comic> builder)
    {
      builder.ToTable(nameof(Comic));
        builder.HasKey(x => x.Id);

        builder.Property(c => c.Title)
            .IsRequired()
            .HasMaxLength(255);

        builder.Property(c => c.Description)
            .HasMaxLength(2000);

        builder.Property(c => c.Author)
            .HasMaxLength(80);

        builder.Property(c => c.Reference)
            .HasMaxLength(50);


        builder.Property(c => c.Pages)
            .HasDefaultValue(1);

        builder.Property(c => c.ImageUrl)
            .IsRequired()
            .HasMaxLength(500);
    }
}
