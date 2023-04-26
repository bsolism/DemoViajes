

namespace DemoViajes.Domain.Repositories
{
    public interface IJourneyRepository
    {
        Task<int> CreateJourney(CreateJourneyDTO journeyDTO);
        Task<IEnumerable<GetJourneysDTO>> GetJourneys();
        Task<IEnumerable<Journey>> GetJourneysCarrierToday(int id);
    }
}
