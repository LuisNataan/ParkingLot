using ParkingLot.Project.Backend.Domain.Entities;

namespace ParkingLot.Project.Backend.Application.Interfaces
{
    public interface IPriceTableService
    {
        Task AddPriceTable(PriceTable priceTable);
        Task UpdatePriceTable(PriceTable priceTable);
        Task DeletePriceTable(int id);
        Task<List<PriceTable>> GetPriceTables();
        Task<PriceTable> GetPriceTableByDate(DateTime entryTime);
    }
}
