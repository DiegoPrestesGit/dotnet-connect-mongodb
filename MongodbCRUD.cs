using MongoDB.Driver;

namespace dotnet_mongodb
{
    public class MongoCRUD
  {
    private IMongoDatabase db;

    public MongoCRUD(string database)
    {
      // connecting to database
      var client = new MongoClient();
      db = client.GetDatabase(database);
    }

    public void Insert<T>(string table, T record)
    {
      var collection = db.GetCollection<T>(table);
      collection.InsertOne(record);
    }
  }
}
