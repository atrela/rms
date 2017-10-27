using ApiGateway.AppConfig;
using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace ApiGateway
{
    /// <summary>
    ///     Configures services and the application's request pipeline.
    /// </summary>
    public class Startup
    {
        private readonly IHostingEnvironment env;

        /// <summary>
        ///     Initializes a new instance of the <see cref="Startup"/> class.
        /// </summary>
        /// <param name="env">An instance of object providing info about web hosting environment.</param>
        public Startup(IHostingEnvironment env)
        {
            this.env = env;

            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
                .AddEnvironmentVariables();

            Configuration = builder.Build();
        }

        /// <summary>
        ///     Gets application configuration API
        /// </summary>
        public IConfigurationRoot Configuration { get; }

        /// <summary>
        ///     Adds services to the container.
        /// </summary>
        /// <param name="services">A collection of defined services.</param>
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<IConfiguration>(Configuration);
            services.AddMvc();
            services.AddMediatR();
            services.AddAutoMapper(typeof(Startup));
            services.AddCustomSwaggerConfig(env);
            services.AddEntityFramework(Configuration);
            services.AddDapperConnection(Configuration);
            services.AddCustomServiceDependencies();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        /// <summary>
        ///     Configures HTTP request pipeline.
        /// </summary>
        /// <remarks>
        ///     The order that middleware components are added in the Configure method defines the order in which
        ///     they are invoked on requests, and the reverse order for the response.
        ///     This ordering is critical for security, performance, and functionality.
        /// </remarks>
        /// <param name="app">An instance of object providing mechanism to configure application request</param>
        /// <param name="env">An instance of object providing information about web hosting environment</param>
        /// <param name="loggerFactory">An instance of object used to configure the logging system and
        /// create instances of <see cref="ILogger"/> from registered logging providers</param>
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole(Configuration.GetSection("Logging"));
            loggerFactory.AddDebug();

            app.UseStaticFiles();
            app.UseMvc();
            app.UseCustomSwaggerSetup();
        }
    }
}