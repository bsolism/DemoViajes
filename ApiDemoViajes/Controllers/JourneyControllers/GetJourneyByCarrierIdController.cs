namespace ApiDemoViajes.Controllers.JourneyControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GetJourneyByCarrierIdController : ControllerBase
    {
        readonly IUnitOfWork UnitOfWork;

        public GetJourneyByCarrierIdController(IUnitOfWork unitOfWork)
        {
            UnitOfWork = unitOfWork;
        }

        [HttpGet("{id}")]
        public async Task<IEnumerable<Journey>> GetJourneysByCarrierId(int id)
        {
            var journey = await UnitOfWork.JourneyRepository.GetJourneysByCarrierId(id);
            return journey;
        }
    }
}
