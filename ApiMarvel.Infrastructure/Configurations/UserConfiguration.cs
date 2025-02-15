using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ApiMarvel.Domain.Models.Users;

namespace ApiMarvel.Infrastructure.Configurations;

public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.ToTable(nameof(User));
        builder.Property(x => x.FullName).HasMaxLength(50).IsRequired(true);
        builder.Property(x => x.Identification).HasMaxLength(50).IsRequired(true);
    }
}