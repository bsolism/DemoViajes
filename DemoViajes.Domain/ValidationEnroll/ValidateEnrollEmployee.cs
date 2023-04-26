namespace DemoViajes.Domain.ValidationEnroll
{
    public class ValidateEnrollEmployee
    {
        public ValidateEnrollEmployee()
        {

        }
        public static bool ValidateKm(EnrollEmployeeDTO enroll)
        {
            if (enroll.Distance > 0 && enroll.Distance <= 50)
            {
                return true;
            }
            return false;
        }

    }
}
