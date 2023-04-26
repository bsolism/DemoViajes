using DemoViajes.Domain.DTOs.CarrierDTOs;

namespace ApiDemoViajes.Controllers.CarrierControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CreateCarrierController : ControllerBase
    {
        readonly IUnitOfWork Uow;

        public CreateCarrierController(IUnitOfWork uow)
        {
            Uow = uow;
        }
        [HttpPost]
        public async Task<IActionResult> CreateCarrier(CreateCarrierDTO carrierDTO)
        {
            var carrier = await Uow.CarrierRepository.CreateCarrier(carrierDTO);

            return Ok(carrier);

        }
    }
}
