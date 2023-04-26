namespace DemoViajes.Domain.Mappers.EmployeeMappers
{
    public class CreateEnrollEmployeeMapper : AgencyAssignmentEmployees
    {
        public static CreateEnrollEmployeeMapper From(EnrollEmployeeDTO enrollDTO)
        {
            var enroll = new CreateEnrollEmployeeMapper
            {
                EmployeeId = enrollDTO.EmployeeId,
                AgencyId = enrollDTO.AgencyId,
                Distance = enrollDTO.Distance
            };

            return enroll;
        }
    }
}
