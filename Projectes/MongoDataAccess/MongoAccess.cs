using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoDataAccess
{
    public class MongoAccess<T> where T : IMongoDataObject
    {
        public MongoAccess(string url, string databaseName, string collectionName)
        {
            DbConfig = new MongoDbConfig(url, databaseName);
            ItemCollection = DbConfig.DataBase.GetCollection<T>(collectionName);
        }

        public MongoAccess(MongoDbConfig dbConfig, string collectionName)
        {
            DbConfig = dbConfig;
            ItemCollection = DbConfig.DataBase.GetCollection<T>(collectionName);
        }

        public MongoDbConfig DbConfig { get; set; }
        public IMongoCollection<T> ItemCollection { get; set; }

        public List<T> SelectAll()
        {
            List<T> items = ItemCollection.Find(x => true).ToList();
            return items;
        }

        public T SelectById(string id)
        {
            T item = ItemCollection.Find(x => x.Id.ToString() == id).FirstOrDefault();
            return item;
        }
    }
}
