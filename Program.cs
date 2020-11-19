namespace dotnet_mongodb
{
  class Program
  {
    static void Main(string[] args)
    {
      var person = new Person{
        FirstName = "Lone", 
        LastName = "Ranger"
      }; 
      MongoCRUD database = new MongoCRUD("AddressBook");
      database.Insert("Persons", person);
    }
  }
}
