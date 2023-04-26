namespace DemoViajes.Domain.Mappers.AgencyMappers
{
    public class GetAgenciesWithEmployeesMapper
    {
        readonly List<EmployeesByAgencyDTO> AgenciesWithEmployeesField = new();

        public static EmployeesByAgencyMapper From(
            IEnumerable<EmployeesByAgencyDTO> agencies)
        {
            var mapper = new EmployeesByAgencyDTO();


            //foreach (var item in agencies)
            //{
            //    var employeEnrol = EmployeesByAgencyMapper.From(item, item.age);
            //    mapper.AddEmployee(employeEnrol);
            //}
            //mapper.Employees = mapper.EmployeesField;


            //return mapper;
            return null;
        }
    }
}
