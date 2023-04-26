namespace DemoViajes.Domain.Entities
{
    public class AgencyAssignmentEmployees
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public Employee? Employee { get; set; }
        public int AgencyId { get; set; }
        public Agency Agency { get; set; }
        public decimal Distance { get; set; }
    }
}
