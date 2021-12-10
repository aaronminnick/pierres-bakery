using System.Collections.Generic;

namespace PierresBakery.Models
{
  public class Bread : BakedItem
  {
    public static List<Bread> Loaves { get; }= new List<Bread> {};
    public override int Price 
    { 
      get
      {
        if (Loaves.IndexOf(this) % 3 == 2)
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
      Loaves.Add(this);
    }

    public void RemoveLoaf()
    {
      Loaves.Remove(this);
    }
    
    public static void ClearAll()
    {
      Loaves.Clear();
    }
  }
}