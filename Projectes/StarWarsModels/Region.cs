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
    public class Region : IMongoDataObject
    {
        [BsonId]
        public ObjectId Id { get; set; }
        public string nameRegion { get; set; }
        public string descriptionRegion { get; set; }
        public string mapRegion { get; set; }
    }
}
