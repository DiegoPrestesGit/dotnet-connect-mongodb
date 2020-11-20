using System;

namespace dotnet_mongodb
{
  public class CRUDService
  {
    public Person InsertExample()
    {
      Address address = new Address
      {
        State = "Stating around",
        Street = "United Streets of New Orleans"
      };

      Person person = new Person
      {
        FirstName = "Simple", 
        LastName = "Man",
        LivinPlace = address
      };

      return person;
    }

    public void InsertDatabase(MongoCRUD database, CRUDService service)
    {
      Person person = service.InsertExample();

      database.Insert("Persons", person);
    }
  }
}
