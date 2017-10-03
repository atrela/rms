using ApiGateway.Domain.Configuration.Agents;
using Moq;
using Xunit;

namespace ApiGateway.Tests.WebAdmin.Configuration.Agents
{
    public class AgentsConfigurationTests
    {
        [Fact]
        public void should_enable_agent()
        {
            var userId = It.IsAny<int>();
            var agentId = It.IsAny<int>();

            var agentRepositoryMock = new Mock<IAgentRepository>();
            agentRepositoryMock.Setup(r => r.Find(agentId)).Returns(new Agent());

            var agent = agentRepositoryMock.Object.Find(agentId);
            agent.Enable(userId);

            agentRepositoryMock.Object.Save(agent);

            agentRepositoryMock.Verify(r => r.Save(agent));
        }
    }
}