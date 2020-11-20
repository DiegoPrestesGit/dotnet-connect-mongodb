using MongoDB.Driver;
using MongoDB.Bson;
using System.Collections.Generic;

namespace dotnet_mongodb
{
    public class MongoCRUD
  {
    private IMongoDatabase db;
    public MongoCRUD(string database) // constructor connecting to database
    { 
      var client = new MongoClient();
      db = client.GetDatabase(database);
    }

    public void Insert<T>(string table, T record)
    {
      var collection = db.GetCollection<T>(table);
      collection.InsertOne(record);
    }

    public List<T> Read<T>(string table)
    {
      var collection = db.GetCollection<T>(table);
      return collection.Find(new BsonDocument()).ToList();
    }
  }
}
