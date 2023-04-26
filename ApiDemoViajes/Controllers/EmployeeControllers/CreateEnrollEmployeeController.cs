using DemoViajes.Domain.DTOs.EnrollEmployee;

namespace ApiDemoViajes.Controllers.EmployeeControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CreateEnrollEmployeeController : ControllerBase
    {
        readonly IUnitOfWork Uow;

        public CreateEnrollEmployeeController(IUnitOfWork uow)
        {
            Uow = uow;
        }
        [HttpPost]
        public async Task<IActionResult> CreateEnrollEmployee(EnrollEmployeeDTO enrollDTO)
        {
            var enroll = await Uow.EmployeeRepository.EnrollEmployee(enrollDTO);
            return Ok(enroll);
        }
    }
}
