using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ParkingLot.Project.Backend.Domain.Entities;

namespace ParkingLot.Project.Backend.Infra.Mappings
{
    public class VehicleMappingConfiguration : IEntityTypeConfiguration<Vehicle>
    {
        public void Configure(EntityTypeBuilder<Vehicle> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Plate)
                   .IsRequired()
                   .HasMaxLength(7);
        }
    }
}
