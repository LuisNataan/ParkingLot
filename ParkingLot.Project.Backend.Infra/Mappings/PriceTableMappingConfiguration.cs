using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ParkingLot.Project.Backend.Domain.Entities;

namespace ParkingLot.Project.Backend.Infra.Mappings
{
    public class PriceTableMappingConfiguration : IEntityTypeConfiguration<PriceTable>
    {
        public void Configure(EntityTypeBuilder<PriceTable> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Price)
                   .IsRequired();

            builder.Property(x => x.AdditionalPrice)
                   .IsRequired();

            builder.Property(x => x.TotalPrice)
                   .IsRequired();

            builder.Property(x => x.EntryTime)
                   .IsRequired()
                   .GetType()
                   .IsAssignableFrom(typeof(DateTime));

            builder.Property(x => x.ExitTime)
                   .IsRequired()
                   .GetType()
                   .IsAssignableFrom(typeof(DateTime));
        }
    }
}
