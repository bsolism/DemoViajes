

using DemoViajes.Domain.ValidationJourneys;

namespace DemoViajesEFCore.Application.Repositories
{
    public class JourneyRepository : IJourneyRepository
    {
        readonly DemoViajesContext Context;

        public JourneyRepository(DemoViajesContext context)
        {
            Context = context;
        }

        public async Task<int> CreateJourney(CreateJourneyDTO journeyDTO)
        {
            var journeyToday = await GetJourneyEmployeeToday(journeyDTO.EmployeeId);
            if (journeyToday) return 0;
            var journeyCarrierToday = await GetJourneysCarrierToday(journeyDTO.CarrierId);
            var validateKm = ValidateCarrierJourney.ValidateJourneyCarrier(journeyCarrierToday, journeyDTO.Distance);
            if (!validateKm) return 0;
            var journey = CreateJourneyMapper.From(journeyDTO);
            await Context.AddAsync(journey);
            await Context.SaveChangesAsync();
            return 1;
        }
        public async Task<bool> GetJourneyEmployeeToday(int id)
        {
            var date = DateTime.Now;
            var employee = await Context.Journeys.FirstOrDefaultAsync(
                x => x.Date.Day == date.Day &&
                x.Date.Month == date.Month &&
                x.Date.Year == date.Year &&
                x.EmployeeId == id);
            if (employee == default) return false;
            return true;
        }

        public async Task<IEnumerable<GetJourneysDTO>> GetJourneys()
        {
            var query = from employee in Context.Employees
                        join journey in Context.Journeys
                        on employee.Id equals journey.EmployeeId
                        join carrier in Context.Carriers
                        on journey.CarrierId equals carrier.Id
                        join agency in Context.Agencies
                        on journey.AgencyId equals agency.Id
                        select new GetJourneysDTO
                        {
                            Id = journey.Id,
                            EmployeeName = employee.Name,
                            EmployeeId = employee.Id,
                            CarrierId = carrier.Id,
                            CarrierName = carrier.Name,
                            AgencyName = agency.Name,
                            Distance = journey.Distance,
                            Date = journey.Date
                        };
            var result = await query.ToListAsync();

            return result;


        }

        public async Task<IEnumerable<Journey>> GetJourneysCarrierToday(int id)
        {
            var date = DateTime.Now;
            var journeyCarrier = await Context.Journeys.Where(
                x => x.Date.Day == date.Day &&
                x.Date.Month == date.Month &&
                x.Date.Year == date.Year &&
                x.CarrierId == id).ToListAsync();
            if (journeyCarrier == default) return null;

            return journeyCarrier;
        }
    }
}
