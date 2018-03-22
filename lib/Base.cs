using System;

namespace lib
{
  public class Base : IBase
  {
    public string Title { get; set; }
    public string Comments { get; set; }
    public Int32 Id { get; set; }
    public bool Removed { get; set; }

    public void Print()
    {
      throw new System.NotImplementedException();
    }

    bool SetRemoved()
    {
      return true;
    }
  }
}