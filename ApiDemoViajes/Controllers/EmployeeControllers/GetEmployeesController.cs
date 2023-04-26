

namespace ApiDemoViajes.Controllers.EmployeeControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GetEmployeesController : ControllerBase
    {
        readonly IUnitOfWork Uow;

        public GetEmployeesController(IUnitOfWork uow)
        {
            Uow = uow;
        }
        [HttpGet]
        public async Task<IEnumerable<Employee>> GetEmployees()
        {
            var employees = await Uow.EmployeeRepository.GetEmployees();
            return employees;
        }
    }
}
