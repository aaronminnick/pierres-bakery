using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;
using System;
using System.Collections.Generic;

namespace PierresBakery.Tests
{
  [TestClass]
  public class PastryTests : IDisposable
  {
    public void Dispose()
    {
      Pastry.ClearAll();
    }

    [TestMethod]
    public void Pastry_CreatesInstanceOfPastry_Pastry()
    {
      Pastry pastry = new Pastry("eclair");
      Assert.AreEqual(typeof(Pastry), pastry.GetType());
    }

    [TestMethod]
    public void GetPrice_ReturnsIndividualPriceBasedOnTotalQtyOfPastries_Int()
    {
      Pastry pastryOne = new Pastry("eclair");
      Pastry pastryTwo = new Pastry("eclair");
      Pastry pastryThree = new Pastry("eclair");
      Pastry pastryFour = new Pastry("eclair");

      Assert.AreEqual(2, pastryOne.Price);
      Assert.AreEqual(2, pastryTwo.Price);
      Assert.AreEqual(1, pastryThree.Price);
      Assert.AreEqual(2, pastryFour.Price);
    }

    [TestMethod]
    public void GetPastries_ReturnsPastries_List()
    {
      Pastry pastryOne = new Pastry("eclair");
      Pastry pastryTwo = new Pastry("eclair");

      List<Pastry> testList = new List<Pastry> {pastryOne, pastryTwo};

      CollectionAssert.AreEqual(testList, Pastry.Pastries);
    }
  }
}