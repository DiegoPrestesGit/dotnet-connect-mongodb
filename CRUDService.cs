using System;
using System.Collections.Generic;

namespace dotnet_mongodb
{
  public class CRUDService
  {
    private MongoCRUD database = new MongoCRUD("AddressBook");

    public Person InsertExample()
    {
      Address address = new Address
      {
        State = "Stating around",
        Street = "United Streets of New Orleans"
      };

      Person person = new Person
      {
        FirstName = "New",
        LastName = "Test",
        LivinPlace = address
      };

      return person;
    }

    public void InsertData(CRUDService service)
    {
      Person person = service.InsertExample();
      database.Insert("Persons", person);
    }

    public List<Person> ReadData()
    {
      var collection = database.Read<Person>("Persons");

      foreach(var data in collection)
      {
        Console.WriteLine($"{data.Id} : {data.FirstName} {data.LastName}");
      }

      return collection;
    }

    public Person ReadDataById(Guid id)
    {
      var dataCollected = database.ReadById<Person>("Persons", id);

      return dataCollected;
    }

    public void UpsertData<T>(string table, Guid id, T data)
    {
      database.UpsertData(table, id, data);
    }
  }
}
