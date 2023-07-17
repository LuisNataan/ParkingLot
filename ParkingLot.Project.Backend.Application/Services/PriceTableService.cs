using ParkingLot.Project.Backend.Application.Interfaces;
using ParkingLot.Project.Backend.Domain.Entities;
using ParkingLot.Project.Backend.Infra.Repositories;

namespace ParkingLot.Project.Backend.Application.Services
{
    public class PriceTableService : IPriceTableService
    {
        private readonly PriceTableRepository _priceTableRepository;

        public PriceTableService(PriceTableRepository priceTableRepository)
        {
            this._priceTableRepository = priceTableRepository;
        }

        public async Task AddPriceTable(PriceTable priceTable)
        {
            await _priceTableRepository.Create(priceTable);
            await _priceTableRepository.SaveChanges();
        }

        public async Task DeletePriceTable(int id)
        {
            var priceTable = new PriceTable() 
            {
                Id = id
            };

            await _priceTableRepository.Delete(priceTable);
            await _priceTableRepository.SaveChanges();
        }

        public async Task<PriceTable> GetPriceTableByDate(DateTime entryTime)
        {
           return await _priceTableRepository.GetPriceTableByDate(entryTime);
        }

        public async Task<List<PriceTable>> GetPriceTables()
        {
            return await _priceTableRepository.GetAllPriceTables();
        }

        public async Task UpdatePriceTable(PriceTable priceTable)
        {
            await _priceTableRepository.Update(priceTable);
            await _priceTableRepository.SaveChanges();
        }
    }
}
