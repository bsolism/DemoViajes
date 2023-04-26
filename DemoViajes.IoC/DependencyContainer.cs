using DemoViajesEFCore.Application;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DemoViajes.IoC
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddService(
            this IServiceCollection service, IConfiguration configuration)
        {
            service.AddRepositories(configuration);

            return service;
        }

    }
}
