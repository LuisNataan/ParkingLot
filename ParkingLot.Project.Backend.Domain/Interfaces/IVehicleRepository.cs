using ParkingLot.Project.Backend.Domain.Entities;
using ParkingLot.Project.Backend.Domain.Interfaces.GenericRepository;

namespace ParkingLot.Project.Backend.Domain.Interfaces
{
    public interface IVehicleRepository : IGenericRepository<Vehicle>
    {
        Task<Vehicle> AddVehicle(string plate);
        Task<Vehicle> GetVehicleByPlate(string plate);
    }
}
