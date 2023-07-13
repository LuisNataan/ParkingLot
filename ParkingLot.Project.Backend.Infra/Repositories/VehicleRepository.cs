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

        public Task<Vehicle> AddVehicle(string plate)
        {
            throw new NotImplementedException();
        }

        public Task<Vehicle> GetVehicleByPlate(string plate)
        {
            throw new NotImplementedException();
        }
    }
}
