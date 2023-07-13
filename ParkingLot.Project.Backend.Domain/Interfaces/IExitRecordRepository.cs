using ParkingLot.Project.Backend.Domain.Entities;
using ParkingLot.Project.Backend.Domain.Interfaces.GenericRepository;

namespace ParkingLot.Project.Backend.Domain.Interfaces
{
    public interface IExitRecordRepository : IGenericRepository<EntryRecord>
    {
        Task AddExitRecordTime(DateTime exitRecordTime);
        Task<EntryRecord> GetExitRecordByPlate(string plate);
    }
}
