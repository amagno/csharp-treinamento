using System;

namespace lib
{
  public class Person : Base
  {
      public DateTime BirthDate { get; set; }
      public Person FatherName { get; set; }
      public string Email { get; set; }

      public static Person GetPeson()
      {
        return new Person() {
          Id = 123,
          Removed = false,
          Title = "Alexandre",
          BirthDate = new DateTime(1991, 1, 11),
          Email = "alexandre.magno@forlogic.net",
          FatherName = new Person() {
            Id = 213123,
            Title = "Alexandre Pai",
            Removed = false
          }
        };
      }
      public new void Print()
      {
        string pai = FatherName != null ? FatherName.Title : "Não possui";
        Console.WriteLine(
          Title + "\n" +
          "Data nascimento: " + BirthDate.ToShortDateString() + "\n" +
          "Email: " + Email + "\n" +
          "Nome do pai: " + pai + "\n"
        );
      }
  }
    
}