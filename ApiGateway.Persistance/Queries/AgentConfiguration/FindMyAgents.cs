using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiGateway.Persistance.Queries.AgentConfiguration
{
    public class FindMyAgents : IRequest<IEnumerable<MyAgentDto>>
    {
        public FindMyAgents()
        {
        }

    }
}
