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
    public class Planet : IMongoDataObject
    {
        [BsonId]
        public ObjectId Id { get; set; }
        public string name { get; set; }
        public string sector { get; set; }
        public string filiation { get; set; }
        public Situation situation { get; set; }
        public Hyperspaceroute hyperspaceRoute { get; set; }
        public string natives { get; set; }
    }

    public class _Id
    {
        public string oid { get; set; }
    }

    public class Situation
    {
        [BsonElement("long")]
        public string Long { get; set; }
        public string lat { get; set; }
        public string parsecs { get; set; }
    }

    public class Hyperspaceroute
    {
        public string[] route { get; set; }
    }

}
