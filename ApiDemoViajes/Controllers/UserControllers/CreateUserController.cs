namespace ApiDemoViajes.Controllers.UserControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CreateUserController : ControllerBase
    {
        readonly IUnitOfWork Uow;

        public CreateUserController(IUnitOfWork uow)
        {
            Uow = uow;
        }
        [HttpPost]
        public async Task<IActionResult> CreateUser(User user)
        {
            var data = await Uow.UserRepository.CreateUser(user);
            if (data == null)
            {
                return BadRequest("Usuario no valido");
            }
            return Ok(data);
        }
    }
}
