namespace ApiDemoViajes.Controllers.JourneyControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GetJourneyByCarrierController : ControllerBase
    {
        readonly IUnitOfWork Uow;

        public GetJourneyByCarrierController(IUnitOfWork uow)
        {
            Uow = uow;
        }
        [HttpGet("{id}")]
        public async Task<IEnumerable<Journey>> GetJourneysByCarrierToday(int id)
        {
            var journey = await Uow.JourneyRepository.GetJourneysCarrierToday(id);
            return journey;
        }

    }
}
