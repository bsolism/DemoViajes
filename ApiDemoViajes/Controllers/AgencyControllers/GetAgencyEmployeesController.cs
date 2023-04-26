namespace ApiDemoViajes.Controllers.AgencyControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GetAgencyEmployeesController : ControllerBase
    {
        readonly IUnitOfWork Uow;

        public GetAgencyEmployeesController(IUnitOfWork uow)
        {
            Uow = uow;
        }
        [HttpGet("{id}")]
        public async Task<EmployeesByAgencyDTO> GetEmployeesByAgency(int id)
        {
            var employees = await Uow.AgencyRepository.GetEmployeesByAgencyId(id);

            return employees;
        }
    }
}
