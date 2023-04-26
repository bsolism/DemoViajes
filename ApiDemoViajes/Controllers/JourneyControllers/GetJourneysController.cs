using DemoViajes.Domain.DTOs.JourneyDTOs;

namespace ApiDemoViajes.Controllers.JourneyControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GetJourneysController : ControllerBase
    {
        readonly IUnitOfWork Uow;

        public GetJourneysController(IUnitOfWork uow)
        {
            Uow = uow;
        }
        [HttpGet]
        public async Task<IEnumerable<GetJourneysDTO>> GetJourneys()
        {
            var journey = await Uow.JourneyRepository.GetJourneys();
            return journey;
        }
    }
}
