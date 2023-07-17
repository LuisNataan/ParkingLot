namespace ParkingLot.Project.Backend.Domain.Entities
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public bool Deleted { get; set; }
    }
}