namespace ParkingLot.Project.Backend.Domain.Entities
{
    public class Vehicle : BaseEntity
    {
        public string Plate { get; set; }

        public Vehicle(string plate)
        {
            this.Plate = plate;
        }
    }
}
