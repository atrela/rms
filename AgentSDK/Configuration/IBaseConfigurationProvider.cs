namespace AgentSDK.Configuration
{
    public interface IBaseConfigurationProvider
    {
        string ServiceDescription { get; }
        string ServiceDisplayName { get; }
        string ServiceName { get; }
    }
}