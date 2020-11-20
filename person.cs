using System;
using MongoDB.Bson.Serialization.Attributes;
namespace dotnet_mongodb
{
  public class Person
  {
    [BsonId]
    public Guid Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public Address LivinPlace { get; set; }
  }
}
