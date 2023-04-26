

namespace DemoViajes.Domain.Repositories
{
    public interface ICarrierRepository
    {
        Task<Carrier> CreateCarrier(CreateCarrierDTO carrierDTO);
        Task<IEnumerable<Carrier>> GetCarriers();
    }
}
