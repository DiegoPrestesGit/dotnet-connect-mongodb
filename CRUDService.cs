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
      return collection;
    }
  }
}
