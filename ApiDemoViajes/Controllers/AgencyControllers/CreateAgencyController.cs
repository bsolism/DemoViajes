

namespace ApiDemoViajes.Controllers.AgencyControllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class CreateAgencyController : ControllerBase
    {
        readonly IUnitOfWork Uow;

        public CreateAgencyController(IUnitOfWork uow)
        {
            Uow = uow;
        }
        [HttpPost]
        public async Task<IActionResult> CreateAgency(CreateAgencyDTO agencyDTO)
        {
            var agency = await Uow.AgencyRepository.CreateAgency(agencyDTO);

            return Ok(agency);

        }
    }
}
