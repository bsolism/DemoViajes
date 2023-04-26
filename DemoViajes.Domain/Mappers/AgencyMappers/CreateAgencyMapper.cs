namespace DemoViajes.Domain.Mappers.AgencyMappers
{
    public class CreateAgencyMapper : Agency
    {
        public static Agency From(CreateAgencyDTO agencyDTO)
        {
            Agency agency = new Agency
            {
                Name = agencyDTO.Name,
                Address = agencyDTO.Address,
            };

            return agency;
        }
    }
}
