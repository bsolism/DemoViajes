


namespace DemoViajes.Domain.Repositories
{
    public interface IEmployeeRepository
    {
        Task<Employee> CreateEmployee(CreateEmployeeDTO employeeDTO);
        Task<IEnumerable<Employee>> GetEmployees();
        Task<int> EnrollEmployee(EnrollEmployeeDTO enroll);
    }
}
