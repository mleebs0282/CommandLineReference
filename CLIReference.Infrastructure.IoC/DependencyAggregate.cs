using CLIReference.Application.Interfaces;
using CLIReference.Application.Services;
using CLIReference.Domain.Interfaces;
using CLIReference.Infrastructure.Data.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace CLIReference.Infrastructure.IoC
{
    public class DependencyAggregate
    {
        public static void RegisterDependencies(IServiceCollection services)
        {
            services.AddScoped<ICommandService, CommandService>();

            services.AddScoped<ICommandRepository, CommandRepository>();
        }
    }
}
