using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Logs.IISAgent.Base
{
    public abstract class MongoDocument
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
    }
}