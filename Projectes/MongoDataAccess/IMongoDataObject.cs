using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoDataAccess
{
    public interface IMongoDataObject
    {
        [BsonId]
        ObjectId Id { get; set; }
    }
}
