namespace ParkingLot.Project.Backend.Domain.Entities
{
    public class PriceTable : BaseEntity
    {
        public decimal Price { get; set; }
        public decimal AdditionalPrice { get; set; }
        public DateTime EntryTime { get; set; }
        public DateTime ExitTime { get; set; }

        public PriceTable(decimal price, decimal chargedPrice, DateTime entryTime, DateTime exitTime)
        {
            Price = price;
            AdditionalPrice = chargedPrice;
            EntryTime = entryTime;
            ExitTime = exitTime;
        }
    }
}
