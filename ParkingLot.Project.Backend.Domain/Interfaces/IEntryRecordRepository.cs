using ParkingLot.Project.Backend.Domain.Entities;
using ParkingLot.Project.Backend.Domain.Interfaces.GenericRepository;

namespace ParkingLot.Project.Backend.Domain.Interfaces
{
    public interface IEntryRecordRepository : IGenericRepository<EntryRecord>
    {
        Task<EntryRecord> AddEntryTime(DateTime entryTime);
        Task<EntryRecord> GetEntryTimeByPlate(string plate);
    }
}
