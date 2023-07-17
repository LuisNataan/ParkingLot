using ParkingLot.Project.Backend.Domain.Entities;

namespace ParkingLot.Project.Backend.Application.Interfaces
{
    public interface IVehicleService
    {
        Task<Vehicle> GetVehicleByPlate(string plate);
        Task DeleteVehicle(int id);
        Task InsertVehicleEntry(Vehicle plateNumber);
        Task InsertVehicleExit(string plateNumber);
        Task<List<Vehicle>> GetAllVehicles();
    }
}
