using System.Threading.Tasks;

namespace ApiGateway.Domain.Configuration.Agents
{
    public interface IAgentRepository
    {
        Task<Agent> FindAsync(int id);

        Task SaveAsync(Agent agent);
    }
}