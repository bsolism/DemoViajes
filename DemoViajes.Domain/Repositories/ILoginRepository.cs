using DemoViajes.Domain.DTOs.LoginDTOs;

namespace DemoViajes.Domain.Repositories
{
    public interface ILoginRepository
    {
        Task<LoginResDTO> Login(LoginReqDTO login);
    }
}
