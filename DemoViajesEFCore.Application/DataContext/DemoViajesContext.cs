

namespace DemoViajesEFCore.Application.DataContext
{
    public class DemoViajesContext : DbContext
    {
        public DemoViajesContext(DbContextOptions<DemoViajesContext> options) : base(options) { }

        public DbSet<Agency> Agencies { get; set; }
        public DbSet<AgencyAssignmentEmployees> AgencyAssignmentEmployees { get; set; }
        public DbSet<Carrier> Carriers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Journey> Journeys { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
