using DemoViajes.Domain.DTOs.JourneyDTOs;

namespace ApiDemoViajes.Controllers.JourneyControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CreateJourneyController : ControllerBase
    {
        readonly IUnitOfWork Uow;

        public CreateJourneyController(IUnitOfWork uow)
        {
            Uow = uow;
        }

        [HttpPost]
        public async Task<int> CreateJourney(CreateJourneyDTO journeyDTO)
        {
            var journey = await Uow.JourneyRepository.CreateJourney(journeyDTO);
            return journey;
        }
    }
}
