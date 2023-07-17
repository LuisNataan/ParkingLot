using Microsoft.EntityFrameworkCore;
using ParkingLot.Project.Backend.Domain.Entities;
using ParkingLot.Project.Backend.Infra.Mappings;

namespace ParkingLot.Project.Backend.Infra.Context
{
    public class MainContext : DbContext
    {
        public MainContext(DbContextOptions options) : base(options) { }

        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<PriceTable> PriceTables { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Vehicle>();
            modelBuilder.Entity<PriceTable>();

            modelBuilder.ApplyConfiguration(new VehicleMappingConfiguration());
            modelBuilder.ApplyConfiguration(new PriceTableMappingConfiguration());


            foreach (var entityType in modelBuilder.Model.GetEntityTypes())
            {
                entityType.GetForeignKeys()
                    .Where(fk => !fk.IsOwnership && fk.DeleteBehavior == DeleteBehavior.Cascade)
                    .ToList().ForEach(fk => fk.DeleteBehavior = DeleteBehavior.Restrict);
                entityType.GetProperties().Where(c => c.ClrType == typeof(string)).ToList()
                    .ForEach(p => p.SetIsUnicode(false));
            }
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(MainContext).Assembly);
        }
    }
}