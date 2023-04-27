

namespace DemoViajesEFCore.Application.UnitOfWorkApplication
{
    public class UnitOfWork : IUnitOfWork
    {
        readonly DemoViajesContext Context;

        public UnitOfWork(DemoViajesContext context)
        {
            Context = context;
        }

        public IAgencyRepository AgencyRepository =>
            new AgencyRepository(Context);

        public IEmployeeRepository EmployeeRepository =>
            new EmployeeRepository(Context);

        public ICarrierRepository CarrierRepository =>
            new CarrierRepository(Context);

        public IJourneyRepository JourneyRepository =>
            new JourneyRepository(Context);

        public ILoginRepository LoginRepository =>
            new LoginRepository(Context);

        public IUserRepository UserRepository =>
            new UserRepository(Context);
    }
}
