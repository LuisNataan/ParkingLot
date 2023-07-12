namespace ParkingLot.Project.Backend.Domain.Entities
{
    public class PriceTable : BaseEntity
    {
        public double Price { get; set; }
        public double TotalPrice { get; set; }
        public double ChargedPrice { get; set; }

        public PriceTable(double price, double totalPrice, double chargedPrice)
        {
            Price = price;
            TotalPrice = totalPrice;
            ChargedPrice = chargedPrice;
        }
    }
}
