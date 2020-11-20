using System;
using MongoDB.Bson.Serialization.Attributes;

namespace dotnet_mongodb
{
  public class Address
  {
    [BsonId]
    public Guid Id { get; set; }
    public string State { get; set; }
    public string Street { get; set; }
  }
}
