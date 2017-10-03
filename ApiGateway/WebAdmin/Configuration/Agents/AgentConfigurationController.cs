using ApiGateway.Domain.Configuration.Agents;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace ApiGateway.WebAdmin.Configuration.Agents
{
    /// <summary>
    ///     Provides access to agents configuration.
    /// </summary>
    [Route("webadmin/configuration/[controller]")]
    public class AgentConfigurationController : Controller
    {
        private readonly IAgentRepository agentRepository;

        /// <summary>
        ///     Initializes a new instance of the <see cref="AgentConfigurationController"/> class.
        /// </summary>
        /// <param name="agentRepository">Data repository of Agent model.</param>
        public AgentConfigurationController(IAgentRepository agentRepository)
        {
            this.agentRepository = agentRepository;
        }

        [HttpPut]
        [Route("{agentId}/enable")]
        public async Task<IActionResult> Enable(int agentId)
        {
            var agent = agentRepository.Find(agentId);
            if (agent == null)
                return BadRequest();

            agent.Enable(1);
            agentRepository.Save(agent);

            return Ok();
        }

        /// <summary>
        ///     Returns list of all available agents.
        /// </summary>
        /// <returns>HTTP Request with list of agents.</returns>
        /// <response code="200">If all data has been retrieved successfully</response>
        /// <response code="400">If data not found</response>
        /// <response code="500">If unknown error occurred</response>
        public async Task<IActionResult> GetAvailableAgents()
        {
            throw new NotImplementedException();
        }
    }
}