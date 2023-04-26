
namespace ApiDemoViajes.Controllers.AgencyControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GetAgenciesController : ControllerBase
    {
        readonly IUnitOfWork Uow;

        public GetAgenciesController(IUnitOfWork uow)
        {
            Uow = uow;
        }
        [HttpGet]
        public async Task<IEnumerable<Agency>> GetAgencies()
        {
            var agencies = await Uow.AgencyRepository.GetAgencies();
            return agencies;
        }
    }
}
