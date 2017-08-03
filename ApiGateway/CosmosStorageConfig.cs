using Logs.Base;
using Microsoft.Extensions.Configuration;

namespace ApiGateway
{
    public class CosmosStorageConfig : IStorageConfiguration
    {
        private readonly IConfiguration apiConfiguration;

        public CosmosStorageConfig(IConfiguration apiConfiguration)
        {
            this.apiConfiguration = apiConfiguration;
        }

        public string ConnectionString
        {
            get { return apiConfiguration.GetConnectionString("DefaultConnString"); }
        }

        public IISDataStorageConfig IISDataStorage
        {
            get { return new IISDataStorageConfig(); }
        }
    }
}