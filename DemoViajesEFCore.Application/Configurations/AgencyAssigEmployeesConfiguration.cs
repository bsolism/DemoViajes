

namespace DemoViajesEFCore.Application.Configurations
{
    internal class AgencyAssigEmployeesConfiguration : IEntityTypeConfiguration<AgencyAssignmentEmployees>
    {
        public void Configure(EntityTypeBuilder<AgencyAssignmentEmployees> builder)
        {
            builder.HasKey(a => a.Id);
            builder.Property(a => a.Distance).HasPrecision(8, 2);
        }
    }
}
