namespace Logs.Base
{
    public interface IStorageConfiguration
    {
        string ConnectionString { get; }
        IISDataStorageConfig IISDataStorage { get; }
    }
}