namespace DemoViajes.Domain.Entities
{
    public class Carrier
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string DNI { get; set; }
        public decimal PricePerKM { get; set; }
    }
}
