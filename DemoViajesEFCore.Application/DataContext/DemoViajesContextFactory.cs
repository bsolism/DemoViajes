namespace DemoViajesEFCore.Application.DataContext
{
    class DemoViajesContextFactory : IDesignTimeDbContextFactory<DemoViajesContext>
    {
        public DemoViajesContext CreateDbContext(string[] args)
        {
            var optionBuilder = new DbContextOptionsBuilder<DemoViajesContext>();

            optionBuilder.UseSqlServer(
                "Server=(localdb)\\mssqllocaldb;database=DemoViajes"
                );

            return new DemoViajesContext(optionBuilder.Options);
        }
    }
}
