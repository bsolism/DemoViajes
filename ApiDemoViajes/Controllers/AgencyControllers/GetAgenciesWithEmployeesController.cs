namespace ApiDemoViajes.Controllers.AgencyControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GetAgenciesWithEmployeesController : ControllerBase
    {
        readonly IUnitOfWork Uow;

        public GetAgenciesWithEmployeesController(IUnitOfWork uow)
        {
            Uow = uow;
        }
        [HttpGet]
        public async Task<IEnumerable<EmployeesByAgencyDTO>> GetAgenciesWithEmployees()
        {
            var agencies = await Uow.AgencyRepository.GetAgenciesWithEmployees();

            return agencies;
        }
    }
}
