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
            var agentId = It.IsAny<int>();

            var agentRepositoryMock = new Mock<IAgentRepository>();
            agentRepositoryMock
                .Setup(r => r.Find(agentId))
                .Returns(Agent.Create(
                    name: It.IsAny<string>(), 
                    description: It.IsAny<string>(), 
                    isEnabled: It.IsAny<bool>()));

            var agent = agentRepositoryMock.Object.Find(agentId);
            agent.Enable();

            agentRepositoryMock.Object.Save(agent);

            agentRepositoryMock.Verify(r => r.Save(agent));
        }
    }
}