using Microsoft.EntityFrameworkCore;
using ParkingLot.Project.Backend.Domain.Entities;
using ParkingLot.Project.Backend.Domain.Interfaces;
using ParkingLot.Project.Backend.Infra.Context;
using ParkingLot.Project.Backend.Infra.Repositories.GenericRepository;

namespace ParkingLot.Project.Backend.Infra.Repositories
{
    public class VehicleRepository : GenericRepository<Vehicle>, IVehicleRepository
    {
        public VehicleRepository(MainContext context) : base(context)
        {
        }

        public async Task<Vehicle> AddVehicle(string plate)
        {
            var vehicle = new Vehicle(plate);
            await _dbSet.AddAsync(vehicle);
            await _context.SaveChangesAsync();
            return vehicle;
        }

        public async Task<Vehicle> GetVehicleByPlate(string plate)
        {
            return await _dbSet.FirstOrDefaultAsync(v => v.Plate == plate);
        }
    }
}
