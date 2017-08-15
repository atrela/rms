namespace AgentSDK.ServiceBase
{
    public interface IService
    {
        void Start();

        void Stop();

        void Pause();

        void Continue();

        void Shutdown();
    }
}