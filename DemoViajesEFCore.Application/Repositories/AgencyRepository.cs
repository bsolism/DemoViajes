
namespace DemoViajesEFCore.Application.Repositories
{
    public class AgencyRepository : IAgencyRepository
    {
        readonly DemoViajesContext Context;

        public AgencyRepository(DemoViajesContext context)
        {
            Context = context;
        }

        public async Task<Agency> CreateAgency(CreateAgencyDTO agencyDTO)
        {
            var agency = CreateAgencyMapper.From(agencyDTO);
            await Context.AddAsync(agency);
            await Context.SaveChangesAsync();
            return agency;
        }

        public async Task<IEnumerable<Agency>> GetAgencies()
        {
            var agencies = await Context.Agencies.ToListAsync();
            return agencies;
        }

        public async Task<IEnumerable<EmployeesByAgencyDTO>> GetAgenciesWithEmployees()
        {
            List<EmployeesByAgencyDTO> Agencies = new();
            var agencies = await GetAgencies();
            foreach (var item in agencies)
            {
                var listEmployees = await Context.AgencyAssignmentEmployees
                .Include(x => x.Employee)
                .Where(x => x.AgencyId == item.Id).ToListAsync();
                var employees = EmployeesByAgencyMapper.From(listEmployees, item);
                Agencies.Add(employees);

            }
            return Agencies;
        }

        public async Task<Agency> GetAgencyById(int id)
        {
            var agency = await Context.Agencies.FirstOrDefaultAsync(x => x.Id == id);
            if (agency == default)
            {
                return null;
            }
            return agency;

        }

        public async Task<EmployeesByAgencyDTO> GetEmployeesByAgencyId(int agencyId)
        {
            var agency = await GetAgencyById(agencyId);
            if (agency == null) return null;

            var listEmployees = await Context.AgencyAssignmentEmployees
                .Include(x => x.Employee)
                .Where(x => x.AgencyId == agencyId).ToListAsync();
            var employees = EmployeesByAgencyMapper.From(listEmployees, agency);

            return employees;
        }
    }
}
