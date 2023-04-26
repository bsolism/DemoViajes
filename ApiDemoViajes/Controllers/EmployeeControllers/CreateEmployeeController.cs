
namespace ApiDemoViajes.Controllers.EmployeeControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CreateEmployeeController : ControllerBase
    {
        readonly IUnitOfWork Uow;

        public CreateEmployeeController(IUnitOfWork uow)
        {
            Uow = uow;
        }
        [HttpPost]
        public async Task<IActionResult> CreateEmployee(CreateEmployeeDTO employeeDTO)
        {
            var employee = await Uow.EmployeeRepository.CreateEmployee(employeeDTO);

            return Ok(employee);

        }
    }
}
