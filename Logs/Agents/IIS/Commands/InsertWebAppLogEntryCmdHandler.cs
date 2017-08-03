using Logs.Base;
using Logs.IISAgent.Model;
using MediatR;
using MongoDB.Driver;
using System.Threading.Tasks;

namespace Logs.Agents.IIS.Commands
{
    public class InsertWebAppLogEntryCmdHandler : IAsyncRequestHandler<InsertWebAppLogEntryCmd>
    {
        private readonly IStorageConfiguration storageConfig;

        public InsertWebAppLogEntryCmdHandler(IStorageConfiguration storageConfig)
        {
            this.storageConfig = storageConfig;
        }

        public async Task Handle(InsertWebAppLogEntryCmd message)
        {
            var mongoClient = new MongoClient(storageConfig.ConnectionString);
            var database = mongoClient.GetDatabase(storageConfig.IISDataStorage.DbName);
            var logsCollection = database.GetCollection<WebAppLogEntry>(storageConfig.IISDataStorage.WebAppDataCollection);

            await logsCollection.InsertOneAsync(message.LogEntry);
        }
    }
}