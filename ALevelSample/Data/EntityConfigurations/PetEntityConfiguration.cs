using ALevelSample.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ALevelSample.Data.EntityConfigurations;

public class PetEntityConfiguration : IEntityTypeConfiguration<PetEntity>
{
    public void Configure(EntityTypeBuilder<PetEntity> builder)
    {
        builder.HasKey(h => h.Id);
        builder.Property(p => p.Name).HasMaxLength(255);
        builder.Property(p => p.CategoryId).HasMaxLength(255);
        builder.Property(p => p.BreedID).HasMaxLength(255);
        builder.Property(p => p.Age).HasMaxLength(255);
        builder.Property(p => p.LocationId).HasMaxLength(255);
        builder.Property(p => p.ImageUrl).HasMaxLength(255);
        builder.Property(p => p.Description).HasMaxLength(255);

        builder.HasOne(h => h.Category)
            .WithMany(w => w.Pet)
            .HasForeignKey(h => h.CategoryId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(h => h.Breed)
            .WithMany(w => w.Pet)
            .HasForeignKey(h => h.BreedID)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(h => h.Location)
            .WithMany(w => w.Pet)
            .HasForeignKey(h => h.LocationId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}