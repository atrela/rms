using MongoDB.Bson;

namespace Logs.IISAgent.Base
{
    public abstract class MongoDocument
    {
        public ObjectId Id { get; set; }
    }
}