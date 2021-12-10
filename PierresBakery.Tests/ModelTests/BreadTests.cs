using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;
using System;
using System.Collections.Generic;

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

    [TestMethod]
    public void GetLoaves_ReturnsLoaves_List()
    {
      Bread breadOne = new Bread("challah");
      Bread breadTwo = new Bread("challah");

      List<Bread> testList = new List<Bread> {breadOne, breadTwo};

      CollectionAssert.AreEqual(testList, Bread.Loaves);
    }

    [TestMethod]
    public void ClearAll_ClearsLoaves_List()
    {
      Bread breadOne = new Bread("challah");
      Bread breadTwo = new Bread("challah");

      List<Bread> testList = new List<Bread> {};
      Bread.ClearAll();

      CollectionAssert.AreEqual(testList, Bread.Loaves);
    }
  }
}