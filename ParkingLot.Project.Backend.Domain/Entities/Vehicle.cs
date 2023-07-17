namespace ParkingLot.Project.Backend.Domain.Entities
{
    public class Vehicle : BaseEntity
    {
        public string Plate { get; set; }
        public DateTime EntryTime { get; set; }
        public DateTime ExitTime { get; set; }

        public Vehicle(string plate, DateTime entryTime, DateTime exitTime)
        {

            this.Plate = plate;
            EntryTime = entryTime;
            ExitTime = exitTime;
        }
    }
}
