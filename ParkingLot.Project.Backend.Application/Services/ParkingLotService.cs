using ParkingLot.Project.Backend.Application.Interfaces;
using ParkingLot.Project.Backend.Domain.Entities;
using ParkingLot.Project.Backend.Infra.Repositories;

namespace ParkingLot.Project.Backend.Application.Services
{
    public class ParkingLotService : IParkingLotService
    {
        private readonly VehicleRepository _vehicleRepository;
        private readonly PriceTableRepository _priceTableRepository;

        public ParkingLotService(VehicleRepository vehicleRepository, PriceTableRepository priceTableRepository)
        {
            this._vehicleRepository = vehicleRepository;
            this._priceTableRepository = priceTableRepository;
        }

        public async Task<decimal> CalculateChargedPrice(string plate, DateTime entryTime, DateTime exitTime)
        {
            Vehicle vehicle = await _vehicleRepository.GetVehicleByPlate(plate);
            PriceTable priceTable = await _priceTableRepository.GetPriceTableByDate(entryTime);

            TimeSpan duration = exitTime - exitTime;

            if (duration.TotalMinutes <= 30)
            {
                return priceTable.Price / 2;
            }

            decimal chargedValue = priceTable.Price;

            TimeSpan addicionalTime = duration - TimeSpan.FromMinutes(30);

            decimal addicionalTimeAmount = (decimal)Math.Ceiling(addicionalTime.TotalHours);

            if (addicionalTime.Minutes <= 10 * addicionalTimeAmount)
            {
                chargedValue += priceTable.AdditionalPrice * addicionalTimeAmount;
            }
            else
            {
                chargedValue += priceTable.AdditionalPrice * (addicionalTimeAmount + 1);
            }

            return chargedValue;
        }
    }
}