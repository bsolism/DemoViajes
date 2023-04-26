namespace DemoViajes.Domain.Mappers.EmployeeMappers
{
    public class CreateEmployeeMapper : Employee
    {
        public static CreateEmployeeMapper From(CreateEmployeeDTO employeeDTO)
        {
            var agency = new CreateEmployeeMapper
            {
                Name = employeeDTO.Name,
                IsManager = employeeDTO.IsManager,
            };

            return agency;
        }
    }
}
