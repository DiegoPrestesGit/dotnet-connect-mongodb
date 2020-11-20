﻿using System;

namespace dotnet_mongodb
{
  class Program
  {
    static void Main(string[] args)
    {
      CRUDService service = new CRUDService();

      // service.InsertData(service);
      // var collectedData = service.ReadData();
      Person collectedPerson = service.ReadDataById(new Guid("b897f789-1b01-426b-b42c-068fbd93cb69"));
      Console.WriteLine($"{collectedPerson.Id} : {collectedPerson.FirstName} {collectedPerson.LastName}");

      Console.WriteLine("GET DOWN TO IT");
    }
  }
}
