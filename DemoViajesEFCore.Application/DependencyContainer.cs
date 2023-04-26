

namespace DemoViajesEFCore.Application
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddRepositories(
            this IServiceCollection services, IConfiguration confiigutation)
        {
            services.AddDbContext<DemoViajesContext>(
                options =>
                options.UseSqlServer(
                    confiigutation.GetConnectionString("DemoViajesCon")));
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            return services;
        }
    }
}
