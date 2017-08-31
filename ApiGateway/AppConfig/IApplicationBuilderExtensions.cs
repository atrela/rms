using Microsoft.AspNetCore.Builder;

namespace ApiGateway.AppConfig
{
    /// <summary>
    ///     Provides extension methods for <see cref="IApplicationBuilder"/> to keep <see cref="Startup"/> class
    ///     clean and readable.
    /// </summary>
    public static class IApplicationBuilderExtensions
    {
        /// <summary>
        ///     Enables custom Swagger configuration.
        /// </summary>
        /// <param name="app">An instance of object providing mechanism to configure application request</param>
        /// <returns>An instance of <see cref="IApplicationBuilder"/> interface</returns>
        public static IApplicationBuilder UseCustomSwaggerSetup(this IApplicationBuilder app)
        {
            app.UseSwagger();
            app.UseSwaggerUI(setup =>
            {
                setup.RoutePrefix = "doc/v1";
                setup.SwaggerEndpoint("/swagger/v1/swagger.json", "RMS API v1");
            });

            return app;
        }
    }
}
