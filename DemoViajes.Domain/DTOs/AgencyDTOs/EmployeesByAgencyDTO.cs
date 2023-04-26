namespace DemoViajes.Domain.DTOs.AgencyDTOs
{
    public class EmployeesByAgencyDTO : Agency
    {
        public List<GetEnrollEmployeeDTO>? Employees { get; set; }
    }
}
