using ApiGateway.Domain.Configuration.Agents;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ApiGateway.WebAdmin.Controllers
{
    /// <summary>
    ///     Provides access to agents configuration.
    /// </summary>
    [Route("webadmin/configuration/agent")]
    public class AgentConfigurationController : Controller
    {
        private readonly IAgentRepository agentRepository;
        private readonly IMediator requestMediator;

        /// <summary>
        ///     Initializes a new instance of the <see cref="AgentConfigurationController"/> class.
        /// </summary>
        /// <param name="agentRepository">Data repository of Agent model.</param>
        /// <param name="requestMediator">Common infrastruture to in-process messaging.</param>
        public AgentConfigurationController(IAgentRepository agentRepository, IMediator requestMediator)
        {
            this.agentRepository = agentRepository;
            this.requestMediator = requestMediator;
        }

        /// <summary>
        ///     Enables given agent.
        /// </summary>
        /// <param name="agentId"></param>
        /// <returns>Standard HTTP response.</returns>
        /// <response code="200">If operation is successfull.</response>
        /// <response code="400">If data not found</response>
        /// <response code="500">If unknown error occurred.</response>
        [HttpPut]
        [Route("{agentId}/enable")]
        public async Task<IActionResult> Enable(int agentId)
        {
            var agent = await agentRepository.FindAsync(agentId);
            if (agent == null)
                return BadRequest();

            agent.Enable();

            await agentRepository.SaveAsync(agent);

            return Ok();
        }
    }
}