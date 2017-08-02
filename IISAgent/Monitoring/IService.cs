namespace RMS.IISAgent.Monitoring
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