using System;

namespace dotnet_mongodb
{
  class Program
  {
    static void Main(string[] args)
    {
      MongoCRUD database = new MongoCRUD("AddressBook");
      CRUDService service = new CRUDService();

      service.InsertDatabase(database, service);

      Console.WriteLine("GET DOWN TO IT");
    }
  }
}
