using System;
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

    public T ReadById<T>(string table, Guid id)
    {
      var collection = db.GetCollection<T>(table);
      var filter = Builders<T>.Filter.Eq("Id", id);

      return collection.Find(filter).First();
    }

    public void UpsertData<T>(string table, Guid id, T data)
    {
      var collection = db.GetCollection<T>(table);
      var result = collection.ReplaceOne(
        new BsonDocument("_id", id),
        data,
        new ReplaceOptions { IsUpsert = true }
      );
    }

    public void DeleteData<T>(string table, Guid id)
    {
      var collection = db.GetCollection<T>(table);
      var filter = Builders<T>.Filter.Eq("Id", id);
      collection.DeleteOne(filter);
    }
  }
}
