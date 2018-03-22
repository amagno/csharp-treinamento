using System;

namespace lib
{
  public class Project : Base
  {
      public string Code { get; set; }
      public DateTime StartDate { get; set; }
      public DateTime EstimatedEndDate { get; set; }
      public DateTime RealEndDate { get; set; }
      public Person Responsible { get; set; }
      public bool MarkFinished()
      {
        return true;
      }
      public static Project GetProject() 
      {
        return new Project() {
          Id = 1,
          Removed = false,
          Title = "Projeto Teste Atividade 1",
          Comments = "",
          Code = new Guid().ToString(),
          StartDate = DateTime.Now,
          EstimatedEndDate = new DateTime(2018, 12, 1),
          RealEndDate = new DateTime(2018, 12, 31),
          Responsible = Person.GetPeson()
        };
      }

      public new void Print()
      {
        
        Console.WriteLine(
          "Projeto: " + Title + "\n" +
          "Codigo: " + Code + "\n" +
          "Começo: " + StartDate.ToShortDateString() + "\n" +
          "Estimado: " + EstimatedEndDate.ToShortDateString() + "\n" +
          "Final: " + RealEndDate.ToShortDateString() + "\n" +
          "Responsavel: "
        );
        Responsible.Print();
      } 

  }
}