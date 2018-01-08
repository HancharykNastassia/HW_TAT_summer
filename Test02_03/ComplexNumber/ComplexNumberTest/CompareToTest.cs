using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ComplexNumberNs;

namespace ComplexNumberTest
{
  [TestClass]
  public class CompareToTest
  {
    [TestMethod]
    public void TestCompareTo()
    {
      Assert.AreEqual(0, new ComplexNumber(1, 1).CompareTo(new ComplexNumber(1, 1)));
      Assert.AreEqual(1, new ComplexNumber(1, 1).CompareTo(new ComplexNumber()));
      Assert.AreEqual(-1, new ComplexNumber().CompareTo(new ComplexNumber(1, 1)));
    }
  }
}
