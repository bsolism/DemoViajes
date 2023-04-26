namespace DemoViajes.Domain.Mappers.AgencyMappers
{
    public class EmployeesByAgencyMapper : EmployeesByAgencyDTO
    {
        readonly List<GetEnrollEmployeeDTO> EmployeesField = new();
        public void AddEmployee(GetEnrollEmployeeDTO employee)
        {

            EmployeesField.Add(employee);
        }


        public static EmployeesByAgencyMapper From(
            IEnumerable<AgencyAssignmentEmployees> employees, Agency agency)
        {
            var mapper = new EmployeesByAgencyMapper
            {
                Id = agency.Id,
                Name = agency.Name,
                Address = agency.Address

            };
            foreach (var item in employees)
            {
                var employeEnrol = new GetEnrollEmployeeDTO
                {
                    Id = item.EmployeeId,
                    Name = item.Employee.Name,
                    IsManager = item.Employee.IsManager,
                    Distance = item.Distance
                };
                mapper.AddEmployee(employeEnrol);
            }
            mapper.Employees = mapper.EmployeesField;


            return mapper;
        }
    }
}
