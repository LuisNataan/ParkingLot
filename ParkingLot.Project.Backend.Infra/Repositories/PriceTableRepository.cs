using Microsoft.EntityFrameworkCore;
using ParkingLot.Project.Backend.Domain.Entities;
using ParkingLot.Project.Backend.Domain.Interfaces;
using ParkingLot.Project.Backend.Infra.Context;
using ParkingLot.Project.Backend.Infra.Repositories.GenericRepository;

namespace ParkingLot.Project.Backend.Infra.Repositories
{
    public class PriceTableRepository : GenericRepository<PriceTable>, IPriceTableRepository
    {
        public PriceTableRepository(MainContext context) : base(context)
        {
        }

        public async Task<PriceTable> GetPriceTableByDate(DateTime date) => await _dbSet.FirstOrDefaultAsync(pt => pt.EntryTime <= date && pt.ExitTime >= date);
    }
}
