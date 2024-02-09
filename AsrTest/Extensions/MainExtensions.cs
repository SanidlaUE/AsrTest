using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AsrTest.Extensions
{
    public static class MyConfigServiceCollectionExtensions
    {
        public static IServiceCollection AddConfig(
             this IServiceCollection services, IConfiguration config)
        {
            //services.Configure<PositionOptions>(
            //    config.GetSection(PositionOptions.Position));
            //services.Configure<ColorOptions>(
            //    config.GetSection(ColorOptions.Color));

            return services;
        }

        public static IServiceCollection AddMyDependencyGroup(
             this IServiceCollection services)
        {
            //services.AddScoped<IMyDependency, MyDependency>();
            //services.AddScoped<IMyDependency2, MyDependency2>();
            
            return services;
        }
    }
}
