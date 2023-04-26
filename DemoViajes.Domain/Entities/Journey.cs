namespace DemoViajes.Domain.Entities
{
    public class Journey
    {
        public int Id { get; set; }
        public int CarrierId { get; set; }
        public Carrier? Carrier { get; set; }
        public int EmployeeId { get; set; }
        public Employee? Employee { get; set; }
        public decimal Distance { get; set; }
        public int AgencyId { get; set; }
        public Agency? Agency { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
    }
}
