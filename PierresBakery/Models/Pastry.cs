using System.Collections.Generic;

namespace PierresBakery.Models
{
  public class Pastry : BakedItem
  {
    public static List<Pastry> Pastries { get; } = new List<Pastry> {};
    public override int Price 
    { 
      get
      {
        if (Pastries.IndexOf(this) % 3 == 2)
        {
          return 1;
        }
        else
        {
          return 2;
        }
      }
    }
    public Pastry(string name) : base(name)
    {
      Pastries.Add(this);
    }

    public static void ClearAll()
    {
      Pastries.Clear();
    }
  }
}