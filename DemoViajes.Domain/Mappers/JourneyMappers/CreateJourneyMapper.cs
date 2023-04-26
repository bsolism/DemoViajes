namespace DemoViajes.Domain.Mappers.JourneyMappers
{
    public class CreateJourneyMapper : Journey
    {
        public static CreateJourneyMapper From(CreateJourneyDTO journeyDTO)
        {
            var journey = new CreateJourneyMapper
            {
                CarrierId = journeyDTO.CarrierId,
                EmployeeId = journeyDTO.EmployeeId,
                AgencyId = journeyDTO.AgencyId,
                Distance = journeyDTO.Distance
            };

            return journey;
        }
    }
}
