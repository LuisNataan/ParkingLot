namespace ParkingLot.Project.Backend.Domain.Entities
{
    public class PriceTable : BaseEntity
    {
        public double Price { get; set; }
        public double TotalPrice { get; set; }
        public double ChargedPrice { get; set; }
        public DateTime EntryTime { get; set; }
        public DateTime ExitTime { get; set; }

        public PriceTable(double price, double totalPrice, double chargedPrice, DateTime entryTime, DateTime exitTime)
        {
            Price = price;
            TotalPrice = totalPrice;
            ChargedPrice = chargedPrice;
            EntryTime = entryTime;
            ExitTime = exitTime;
        }
    }
}
