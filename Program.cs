using System;

namespace dotnet_mongodb
{
  class Program
  {
    static void Main(string[] args)
    {
      Address address = new Address
      {
        State = "Stating around",
        Street = "United Streets of New Orleans"
      };

      Person person = new Person
      {
        FirstName = "Lone", 
        LastName = "Ranger",
        LivinPlace = address
      };

      MongoCRUD database = new MongoCRUD("AddressBook");
      database.Insert("Persons", person);
      Console.WriteLine("GET DOWN TO IT");
    }
  }
}
