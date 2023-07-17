using ParkingLot.Project.Backend.Application.Interfaces;
using ParkingLot.Project.Backend.Domain.Entities;
using ParkingLot.Project.Backend.Infra.Repositories;

namespace ParkingLot.Project.Backend.Application.Services
{
    public class VehicleService : IVehicleService
    {
        private readonly VehicleRepository _vehicleRepository;

        public async Task InsertVehicleEntry(Vehicle plateNumber)
        {
            plateNumber.EntryTime = DateTime.Now;
            await _vehicleRepository.AddVehicle(plateNumber.ToString());
            await _vehicleRepository.SaveChanges();
        }

        public async Task InsertVehicleExit(string plateNumber)
        {
            Vehicle vehicle = await _vehicleRepository.GetVehicleByPlate(plateNumber);
            if (vehicle != null)
            {
                vehicle.ExitTime = DateTime.Now;
                await _vehicleRepository.SaveChanges();
            }
        }

        public Task DeleteVehicle(int id)
        {
            var vehicleId = new Vehicle()
            {
                Id = id,
            };
            return _vehicleRepository.Delete(vehicleId);
        }

        public async Task<List<Vehicle>> GetAllVehicles()
        {
            return await _vehicleRepository.GetAllVehicles();
        }

        public async Task<Vehicle> GetVehicleByPlate(string plate)
        {
            return await _vehicleRepository.GetVehicleByPlate(plate);
        }
    }
}
