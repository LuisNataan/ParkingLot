namespace ParkingLot.Project.Backend.Application.Interfaces
{
    public interface IParkingLotService
    {
        Task<decimal> CalculateChargedPrice(string plate, DateTime entryTime, DateTime exitTime);
    }
}
