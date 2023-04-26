using DemoViajes.Domain.DTOs.CarrierDTOs;

namespace DemoViajes.Domain.Mappers.CarrierMappers
{
    public class CreateCarrierMapper : Carrier
    {
        public static CreateCarrierMapper From(CreateCarrierDTO carrierDTO)
        {
            var carrier = new CreateCarrierMapper
            {
                Name = carrierDTO.Name,
                DNI = carrierDTO.DNI,
                PricePerKM = carrierDTO.PricePerKM,
            };

            return carrier;
        }
    }
}
