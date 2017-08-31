using Logs.Base;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.PlatformAbstractions;
using Swashbuckle.AspNetCore.Swagger;
using System.IO;

namespace ApiGateway.AppConfig
{
    /// <summary>
    ///     Provides extension methods for <see cref="IServiceCollection"/> class to keep <see cref="Startup"/>
    ///     class clean and readble.
    /// </summary>
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        ///     Configures and adds Swagger Generator service to the container.
        /// </summary>
        /// <param name="services">A collection of defined services.</param>
        /// <returns>An instance of <see cref="IServiceCollection"/> interface</returns>
        public static IServiceCollection AddCustomSwaggerConfig(this IServiceCollection services)
        {
            services.AddSwaggerGen(setup =>
            {
                setup.SwaggerDoc("v1", new Info { Title = "Resource Monitoring Suite API", Version = "v1" });

                //Set the comments path for the swagger json and ui.
                var basePath = PlatformServices.Default.Application.ApplicationBasePath;
                var xmlPath = Path.Combine(basePath, "ApiGateway.xml");
                setup.IncludeXmlComments(xmlPath);
            });

            return services;
        }

        /// <summary>
        ///     Adds custom services to the container.
        /// </summary>
        /// <param name="services">A collection of defined services</param>
        /// <returns>An instance of <see cref="IServiceCollection"/> interface</returns>
        public static IServiceCollection AddCustomServiceDependencies(this IServiceCollection services)
        {
            services.AddTransient<IStorageConfiguration, CosmosStorageConfig>();
            return services;
        }
    }
}
