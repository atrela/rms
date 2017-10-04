using ApiGateway.Domain.Configuration.Agents;
using ApiGateway.Persistance.Context;
using System.Collections.Generic;
using System.Linq;

namespace ApiGateway.Persistance.Init
{
    public static class ConfigurationSchemaInitializer
    {
        public static void Initialize(RmsConfigurationContext context)
        {
            SeedAgents(context);

            context.SaveChanges();
        }

        private static void SeedAgents(RmsConfigurationContext context)
        {
            if (!context.Agents.Any())
            {
                var agents = new List<Agent>
                {
                    Agent.Create("IIS Agent", "Monitors statistics of web applications hosted on IIS server.")
                };
                context.Agents.AddRange(agents);
            }
        }
    }
}