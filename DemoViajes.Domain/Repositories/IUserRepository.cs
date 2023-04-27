namespace DemoViajes.Domain.Repositories
{
    public interface IUserRepository
    {
        Task<User> CreateUser(User user);
    }
}
