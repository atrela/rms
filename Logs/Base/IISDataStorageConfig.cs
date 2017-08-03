namespace Logs.Base
{
    public class IISDataStorageConfig
    {
        public string DbName
        {
            get { return "iislogs"; }
        }

        public string WebAppDataCollection
        {
            get { return "webappdata"; }
        }
    }
}