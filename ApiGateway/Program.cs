using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore;
using Microsoft.Extensions.DependencyInjection;
using ApiGateway.Persistance.Context;
using ApiGateway.Persistance.Init;

namespace ApiGateway
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = BuildWebHost(args);

            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                InitConfigurationSchema(services);
            }

            host.Run();
        }

        private static void InitConfigurationSchema(IServiceProvider services)
        {
            var dbConfigruationSchemaContext = services.GetRequiredService<RmsConfigurationContext>();
            ConfigurationSchemaInitializer.Initialize(dbConfigruationSchemaContext);
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .Build();
    }
}
