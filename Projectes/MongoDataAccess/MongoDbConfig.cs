using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoDataAccess
{
    public class MongoDbConfig
    {
        public MongoDbConfig(string url, string databaseName)
        {
            Client = new MongoClient(url);
            DataBase = Client.GetDatabase(databaseName);
        }

        public MongoClient Client { get; set; }
        public IMongoDatabase DataBase { get; set; }
    }
}
