using ALevelSample.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ALevelSample.Data.EntityConfigurations;

public class BreedEntityConfiguration : IEntityTypeConfiguration<BreedEntity>
{
    public void Configure(EntityTypeBuilder<BreedEntity> builder)
    {
        builder.HasKey(h => h.Id);
        builder.Property(p => p.UserId).IsRequired();

        builder.HasOne(h => h.User)
            .WithMany(w => w.Orders)
            .HasForeignKey(h => h.UserId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}