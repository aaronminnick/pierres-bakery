namespace PierresBakery.Models
{
  public class Bread : BakedItem
  {
    public override int Price { get; }
    public Bread(string name) : base(name)
    {
      Price = 5;
    }
  }
}