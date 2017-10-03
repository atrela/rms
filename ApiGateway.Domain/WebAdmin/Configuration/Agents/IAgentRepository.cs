using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiGateway.Domain.Configuration.Agents
{
    public interface IAgentRepository
    {
        Agent Find(int id);
        void Save(Agent agent);
    }
}
