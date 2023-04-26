namespace DemoViajes.Domain.DTOs.JourneyDTOs
{
    public class CreateJourneyDTO
    {
        public int CarrierId { get; set; }
        public int EmployeeId { get; set; }
        public int AgencyId { get; set; }
        public decimal Distance { get; set; }
    }
}
