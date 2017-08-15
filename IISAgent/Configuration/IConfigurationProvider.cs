using AgentSDK.Configuration;

namespace RMS.IISAgent.Configuration
{
    public interface IConfigurationProvider : IBaseConfigurationProvider
    {
        double MonitorTimerInterval { get; }
        string GatewayUrl { get; }
    }
}