using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;
using System;

namespace PierresBakery.Tests
{
  [TestClass]
  public class BreadTests : IDisposable
  {
    public void Dispose()
    {
      Bread.ClearAll();
    }

    [TestMethod]
    public void Bread_CreatesInstanceOfBread_Bread()
    {
      Bread bread = new Bread("challah");
      Assert.AreEqual(typeof(Bread), bread.GetType());
    }

    [TestMethod]
    public void GetPrice_ReturnsIndividualPriceBasedOnTotalQtyOfLoaves_Int()
    {
      Bread breadOne = new Bread("challah");
      Bread breadTwo = new Bread("challah");
      Bread breadThree = new Bread("challah");
      Bread breadFour = new Bread("challah");

      Assert.AreEqual(5, breadOne.Price);
      Assert.AreEqual(5, breadTwo.Price);
      Assert.AreEqual(0, breadThree.Price);
      Assert.AreEqual(5, breadFour.Price);
    }
  }
}