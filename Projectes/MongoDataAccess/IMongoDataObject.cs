using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoDataAccess
{
    // Amb aquesta interficie podrem accedir al id a l'hora de fer una cerca en MongoAccess.
    public interface IMongoDataObject
    {
        [BsonId]
        ObjectId Id { get; set; }
    }
}
