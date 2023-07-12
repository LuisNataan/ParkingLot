namespace ParkingLot.Project.Backend.Domain.Entities
{
    public class EntryRecord : BaseEntity
    {
        public DateTime ArrivalTime { get; set; }
        public DateTime DepartureTime { get; set; }
        public TimeSpan Duration { get; protected set; }

        public EntryRecord(DateTime arrivalTime, DateTime departureTime)
        {
            this.ArrivalTime = arrivalTime;
            this.DepartureTime = departureTime;
            this.GetDurationTime();
        }

        protected void GetDurationTime()
        {
            Duration = DepartureTime - ArrivalTime;
        }
    }
}
