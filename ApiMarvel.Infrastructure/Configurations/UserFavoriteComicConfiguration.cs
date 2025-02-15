using ApiMarvel.Domain.Models.Users;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace ApiMarvel.Infrastructure.Configurations;

public class UserFavoriteComicConfiguration : IEntityTypeConfiguration<UserFavoriteComic>
{
    public void Configure(EntityTypeBuilder<UserFavoriteComic> builder)
    {
        builder.ToTable("UserFavoriteComics");

        builder.HasKey(ufc => ufc.Id);

        builder.Property(ufc => ufc.Id)
            .IsRequired()
            .ValueGeneratedOnAdd();

        builder.HasOne(ufc => ufc.User)
            .WithMany() 
            .HasForeignKey(ufc => ufc.UserId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(ufc => ufc.Comic)
            .WithMany() 
            .HasForeignKey(ufc => ufc.ComicId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}

