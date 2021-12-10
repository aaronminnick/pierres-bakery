using System.Collections.Generic;

namespace PierresBakery.Models
{
  public class Pastry : BakedItem
  {
    private static List<Pastry> _pastries = new List<Pastry> {};
    public override int Price 
    { 
      get
      {
        if (_pastries.IndexOf(this) % 3 == 2)
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
      _pastries.Add(this);
    }

    public static void ClearAll()
    {
      _pastries.Clear();
    }
  }
}