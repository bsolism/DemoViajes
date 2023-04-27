using DemoViajes.Domain.DTOs.LoginDTOs;

namespace ApiDemoViajes.Controllers.LoginControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        readonly IUnitOfWork Uow;

        public LoginController(IUnitOfWork uow)
        {
            Uow = uow;
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginReqDTO loginReqDto)
        {
            var login = await Uow.LoginRepository.Login(loginReqDto);
            if (login == null)
            {
                return BadRequest("El usuario no cumple requisitos");
            }
            return Ok(login);
        }
    }
}
