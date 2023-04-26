using DemoViajes.Domain.DTOs.CarrierDTOs;
using DemoViajes.Domain.Mappers.CarrierMappers;

namespace DemoViajesEFCore.Application.Repositories
{
    public class CarrierRepository : ICarrierRepository
    {
        readonly DemoViajesContext Context;

        public CarrierRepository(DemoViajesContext context)
        {
            Context = context;
        }

        public async Task<Carrier> CreateCarrier(CreateCarrierDTO carrierDTO)
        {
            var carrier = CreateCarrierMapper.From(carrierDTO);
            await Context.AddAsync(carrier);
            await Context.SaveChangesAsync();
            return carrier;
        }

        public async Task<IEnumerable<Carrier>> GetCarriers()
        {
            var carriers = await Context.Carriers.ToListAsync();
            return carriers;
        }
    }
}
