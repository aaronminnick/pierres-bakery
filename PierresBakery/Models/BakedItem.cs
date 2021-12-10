namespace PierresBakery.Models
{
  public abstract class BakedItem
  {
    public abstract int Price { get; }
    public string Name { get; }
    public BakedItem(string name)
    {
      Name = name;
    }
  }
}