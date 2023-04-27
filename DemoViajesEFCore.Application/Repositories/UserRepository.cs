using DemoViajes.Domain.Helper.Tokens;

namespace DemoViajesEFCore.Application.Repositories
{
    public class UserRepository : IUserRepository
    {
        readonly DemoViajesContext Context;

        public UserRepository(DemoViajesContext context)
        {
            Context = context;
        }

        public async Task<User> CreateUser(User user)
        {
            var ExistEmployee = await Context.Employees
                .FirstOrDefaultAsync(x => x.Name == user.UserName);
            if (ExistEmployee == default) return null;
            if (!ExistEmployee.IsManager) return null;
            var ExistUser = await Context.Users.FirstOrDefaultAsync(x => x.UserName == user.UserName);
            if (ExistUser != default) return null;
            var hash = Hash.Hashs(user.Password);
            user.Password = hash.Password;
            user.Sal = hash.Salt;
            await Context.AddAsync(user);
            await Context.SaveChangesAsync();

            return user;

        }
    }
}
