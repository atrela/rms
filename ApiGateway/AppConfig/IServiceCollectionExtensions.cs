﻿using ApiGateway.Domain.Configuration.Agents;
using ApiGateway.Persistance.Context;
using ApiGateway.Persistance.Repositories.Configuration;
using Logs.Base;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Swashbuckle.AspNetCore.Swagger;
using System.IO;
using System.Reflection;

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
        /// <param name="services">A collection of defined services</param>
        /// <param name="env">An instance of object providing info about web hosting environment</param>
        /// <returns>An instance of <see cref="IServiceCollection"/> interface</returns>
        public static IServiceCollection AddCustomSwaggerConfig(this IServiceCollection services,
            IHostingEnvironment env)
        {
            services.AddSwaggerGen(setup =>
            {
                setup.SwaggerDoc("v1", new Info { Title = "Resource Monitoring Suite API", Version = "v1" });

                //Set the comments path for the swagger json and ui.
                var webRootPath = env.WebRootPath;
                var v1DocPath = Path.Combine("doc", "v1");
                var xmlPath = Path.Combine(webRootPath, v1DocPath, "ApiGateway.xml");
                setup.IncludeXmlComments(xmlPath);
            });

            return services;
        }

        /// <summary>
        ///     Adds Entity Framework configuration to the container.
        /// </summary>
        /// <param name="services">A collection of defined services</param>
        /// <param name="configuration">Application configuration API</param>
        /// <returns></returns>
        public static IServiceCollection AddEntityFramework(this IServiceCollection services, IConfigurationRoot configuration)
        {
            services.AddEntityFrameworkSqlServer()
                .AddDbContext<RmsConfigurationContext>(opt =>
                {
                    opt.UseSqlServer(
                        configuration.GetConnectionString("DefaultConnString"),
                        sql => sql.MigrationsAssembly(typeof(RmsConfigurationContext).GetTypeInfo().Assembly.GetName().Name));
                },
                ServiceLifetime.Scoped);

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
            services.AddScoped<IAgentRepository, AgentRepository>();
            return services;
        }

       
    }
}