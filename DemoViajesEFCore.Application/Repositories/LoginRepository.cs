using DemoViajes.Domain.DTOs.LoginDTOs;
using DemoViajes.Domain.Helper.Tokens;

namespace DemoViajesEFCore.Application.Repositories
{
    public class LoginRepository : ILoginRepository
    {
        readonly DemoViajesContext Context;

        public LoginRepository(DemoViajesContext context)
        {
            Context = context;
        }

        public async Task<LoginResDTO> Login(LoginReqDTO login)
        {
            var user = await Context.Users.FirstOrDefaultAsync(x => x.UserName == login.UserName);
            if (user == default) return null;
            var verification = Hash.CheckHash(login.Password, user.Password, user.Sal);
            if (verification == false) return null;
            CreateToken token = new CreateToken();
            var resp = new LoginResDTO
            {
                Name = login.UserName,
                Token = token.CreateJWT(user)
            };
            return resp;
        }
    }
}
