namespace ApiDemoViajes.Controllers.CarrierControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GetCarriersController : ControllerBase
    {
        readonly IUnitOfWork Uow;

        public GetCarriersController(IUnitOfWork uow)
        {
            Uow = uow;
        }
        [HttpGet]
        public async Task<IEnumerable<Carrier>> GetCarriers()
        {
            var carriers = await Uow.CarrierRepository.GetCarriers();
            return carriers;
        }
    }
}
