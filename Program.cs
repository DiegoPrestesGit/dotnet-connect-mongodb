using System;

namespace dotnet_mongodb
{
  class Program
  {
    static void Main(string[] args)
    {
      CRUDService service = new CRUDService();

      // service.InsertData(service);
      var collectedData = service.ReadData();

      foreach(var data in collectedData)
      {
        Console.WriteLine($"{data.Id} : {data.FirstName} {data.LastName}");
      }

      Console.WriteLine("GET DOWN TO IT");
    }
  }
}
