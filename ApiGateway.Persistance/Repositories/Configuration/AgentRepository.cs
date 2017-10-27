using ApiGateway.Domain.Configuration.Agents;
using ApiGateway.Persistance.Context;
using System.Threading.Tasks;

namespace ApiGateway.Persistance.Repositories.Configuration
{
    public class AgentRepository : IAgentRepository
    {
        private readonly RmsConfigurationContext context;

        public AgentRepository(RmsConfigurationContext context)
        {
            this.context = context;
        }

        public async Task<Agent> FindAsync(int id)
        {
            return await context.Agents.FindAsync(id);
        }

        public async Task SaveAsync(Agent agent)
        {
            if (agent.Id == 0)
                await Insert(agent);
            else
                await Update(agent);
        }

        private async Task Insert(Agent agent)
        {
            context.Agents.Add(agent);
            await context.SaveChangesAsync();
        }

        private async Task Update(Agent agent)
        {
            var originalAgent = await context.Agents.FindAsync(agent.Id);
            context.Entry(originalAgent).CurrentValues.SetValues(agent);
            await context.SaveChangesAsync();
        }
    }
}