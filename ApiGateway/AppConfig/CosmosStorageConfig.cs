using Logs.Base;
using Microsoft.Extensions.Configuration;

namespace ApiGateway
{
    /// <summary>
    ///     Provides access to the configuration of Azure Cosmos DB.
    /// </summary>
    public class CosmosStorageConfig : IStorageConfiguration
    {
        private readonly IConfiguration apiConfiguration;

        /// <summary>
        ///     Initializes a new instance of the <see cref="CosmosStorageConfig"/> class.
        /// </summary>
        /// <param name="apiConfiguration"></param>
        public CosmosStorageConfig(IConfiguration apiConfiguration)
        {
            this.apiConfiguration = apiConfiguration;
        }

        /// <summary>
        ///     Gets Azure Cosmos DB connection string.
        /// </summary>
        public string ConnectionString
        {
            get { return apiConfiguration.GetConnectionString("DefaultConnString"); }
        }

        /// <summary>
        ///     Gets cofniguration of data storage for IIS Agent.
        /// </summary>
        public IISDataStorageConfig IISDataStorage
        {
            get { return new IISDataStorageConfig(); }
        }
    }
}