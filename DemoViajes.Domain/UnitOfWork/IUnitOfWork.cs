namespace DemoViajes.Domain.UnitOfWork
{
    public interface IUnitOfWork
    {
        IAgencyRepository AgencyRepository { get; }
        IEmployeeRepository EmployeeRepository { get; }
        ICarrierRepository CarrierRepository { get; }
        IJourneyRepository JourneyRepository { get; }
    }
}
