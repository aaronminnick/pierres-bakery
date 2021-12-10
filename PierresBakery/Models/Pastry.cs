namespace PierresBakery.Models
{
  public class Pastry : BakedItem
  {
    public override int Price { get; }
    public Pastry(string name) : base(name)
    {
      Price = 2;
    }
  }
}