using ParkingLot.Project.Backend.Domain.Entities;
using ParkingLot.Project.Backend.Domain.Interfaces.GenericRepository;

namespace ParkingLot.Project.Backend.Domain.Interfaces
{
    public interface IPriceTableRepository : IGenericRepository<PriceTable>
    {
        Task<PriceTable> GetPriceTableByDate(DateTime date);
        Task<PriceTable> UpdatePriceTable(PriceTable priceTable);
    }
}
