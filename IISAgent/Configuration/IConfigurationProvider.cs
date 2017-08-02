namespace RMS.IISAgent.Configuration
{
    public interface IConfigurationProvider
    {
        string ServiceDescription { get; }
        string ServiceDisplayName { get; }
        string ServiceName { get; }

        double MonitorTimerInterval { get; }
        string GatewayUrl { get; }
    }
}