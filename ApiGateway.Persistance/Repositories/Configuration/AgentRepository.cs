using ApiGateway.Domain.Configuration.Agents;
using ApiGateway.Persistance.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiGateway.Persistance.Repositories.Configuration
{
    public class AgentRepository : IAgentRepository
    {
        private readonly RmsConfigurationContext context;

        public AgentRepository(RmsConfigurationContext context)
        {
            this.context = context;
        }

        public Agent Find(int id)
        {
            throw new NotImplementedException();
        }

        public void Save(Agent agent)
        {
            throw new NotImplementedException();
        }
    }
}
