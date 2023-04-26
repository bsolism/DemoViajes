namespace DemoViajes.Domain.Repositories
{
    public interface IAgencyRepository
    {
        Task<Agency> CreateAgency(CreateAgencyDTO agencyDTO);
        Task<IEnumerable<Agency>> GetAgencies();
        Task<Agency> GetAgencyById(int id);
        Task<EmployeesByAgencyDTO> GetEmployeesByAgencyId(int agencyId);
        Task<IEnumerable<EmployeesByAgencyDTO>> GetAgenciesWithEmployees();

    }
}
