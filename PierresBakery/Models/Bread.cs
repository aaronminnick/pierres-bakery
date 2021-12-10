using System.Collections.Generic;

namespace PierresBakery.Models
{
  public class Bread : BakedItem
  {
    private static List<Bread> _loaves = new List<Bread> {};
    public override int Price 
    { 
      get
      {
        if (_loaves.IndexOf(this) % 3 == 2)
        {
          return 0;
        }
        else
        {
          return 5;
        }
      }
    }
    public Bread(string name) : base(name)
    {
      _loaves.Add(this);
    }

    public static void ClearAll()
    {
      _loaves.Clear();
    }
  }
}