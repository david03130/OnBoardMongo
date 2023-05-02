using MongoDataAccess;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWarsModels
{
    public class HyperspaceRoutes : IMongoDataObject
    {
        [BsonId]
        public ObjectId Id { get; set; }
        public string type { get; set; }
        public string nameRoute { get; set; }
        public string start { get; set; }
        public string end { get; set; }
    }

}
