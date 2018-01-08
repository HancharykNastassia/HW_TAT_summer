using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Cars;

namespace CarSorterTests
{
  [TestClass]
  public class SortCarsTests
  {
    [TestMethod]
    public void TestSortCars1()
    {
      Car[] cars = { new Car("","","",1), new Car("","","",0) };
      Car[] expectedCars = { new Car("","","",0), new Car("","","",1) };
      CarSorter carSorter = new CarSorter(cars);
      carSorter.SortCars();
      Array.Copy(carSorter.Cars, cars, 2);
      CollectionAssert.AreEqual(expectedCars, cars);
    }
  }
}
