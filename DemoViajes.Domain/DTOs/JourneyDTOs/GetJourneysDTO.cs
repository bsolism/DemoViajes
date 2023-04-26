namespace DemoViajes.Domain.DTOs.JourneyDTOs
{
    public class GetJourneysDTO
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string AgencyName { get; set; }
        public int CarrierId { get; set; }
        public string CarrierName { get; set; }
        public decimal Distance { get; set; }
        public DateTime Date { get; set; }

    }
}
