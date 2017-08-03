using Logs.Base;
using Logs.IISAgent.Model;
using MediatR;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Logs.Agents.IIS.Queries
{
    public class GetAllLogEntriesQueryHandler : IAsyncRequestHandler<GetAllLogEntriesQuery, IEnumerable<WebAppLogEntry>>
    {
        private readonly IStorageConfiguration storageConfig;

        public GetAllLogEntriesQueryHandler(IStorageConfiguration storageConfig)
        {
            this.storageConfig = storageConfig;
        }

        public async Task<IEnumerable<WebAppLogEntry>> Handle(GetAllLogEntriesQuery message)
        {
            var mongoClient = new MongoClient(storageConfig.ConnectionString);
            var database = mongoClient.GetDatabase(storageConfig.IISDataStorage.DbName);

            return await database
                .GetCollection<WebAppLogEntry>(storageConfig.IISDataStorage.WebAppDataCollection)
                .Find(new BsonDocument()).ToListAsync();
        }
    }
}