using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CheckingStringToBeInt;

namespace TestStringToBeIntChecker
{
  [TestClass]
  public class TestStringToBeIntChecker
  {
    [TestMethod]
    public void TestMethod1()
    {
      Assert.IsTrue(new StringToBeIntChecker("1234").IsStringInteger());
    }

    [TestMethod]
    public void TestMethod2()
    {
      Assert.IsFalse(new StringToBeIntChecker("abcd").IsStringInteger());
    }

    [TestMethod]
    public void TestMethod3()
    {
      Assert.IsTrue(new StringToBeIntChecker("1,234").IsStringInteger());
    }

    [TestMethod]
    public void TestMethod4()
    {
      Assert.IsTrue(new StringToBeIntChecker("1,234.00").IsStringInteger());
    }

    [TestMethod]
    public void TestMethod5()
    {
      Assert.IsFalse(new StringToBeIntChecker("1,2.34").IsStringInteger());
    }

    [TestMethod]
    public void TestMethod6()
    {
      Assert.IsFalse(new StringToBeIntChecker("1,2.34.00").IsStringInteger());
    }

    [TestMethod]
    public void TestMethod7()
    {
      Assert.IsFalse(new StringToBeIntChecker(".123400").IsStringInteger());
    }
  }
}
