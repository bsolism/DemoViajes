

using DemoViajes.Domain.DTOs.EnrollEmployee;
using DemoViajes.Domain.ValidationEnroll;

namespace DemoViajesEFCore.Application.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        readonly DemoViajesContext Context;

        public EmployeeRepository(DemoViajesContext context)
        {
            Context = context;
        }

        public async Task<Employee> CreateEmployee(CreateEmployeeDTO employeeDTO)
        {
            var employee = CreateEmployeeMapper.From(employeeDTO);
            await Context.AddAsync(employee);
            await Context.SaveChangesAsync();
            return employee;
        }

        public async Task<int> EnrollEmployee(EnrollEmployeeDTO enrollDTO)
        {
            bool existEmployee = await GetEmployeFromAgency(enrollDTO);
            if (existEmployee) return 0;
            bool validateKM = ValidateEnrollEmployee.ValidateKm(enrollDTO);
            if (!validateKM) return 0;
            var enroll = CreateEnrollEmployeeMapper.From(enrollDTO);
            await Context.AgencyAssignmentEmployees.AddAsync(enroll);
            await Context.SaveChangesAsync();
            return 1;
        }

        public async Task<IEnumerable<Employee>> GetEmployees()
        {
            var employees = await Context.Employees.ToListAsync();
            return employees;
        }
        public async Task<bool> GetEmployeFromAgency(EnrollEmployeeDTO enrollDTO)
        {
            var existEmployee = await Context.AgencyAssignmentEmployees
                .FirstOrDefaultAsync(x =>
                x.AgencyId == enrollDTO.AgencyId &&
                x.EmployeeId == enrollDTO.EmployeeId);
            if (existEmployee == default)
            {
                return false;
            }
            return true;


        }
    }

}
