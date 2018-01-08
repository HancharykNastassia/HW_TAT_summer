using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ComplexNumberNs;

namespace ComplexNumberTest
{
  [TestClass]
  public class OperatorMultiplyTest
  {
    [TestMethod]
    public void TestOperatorMultiply()
    {
      ComplexNumber number = new ComplexNumber(1, 2) * new ComplexNumber(1, 2);
      Assert.AreEqual(-3, number.Re);
      Assert.AreEqual(4, number.Im);
      number = new ComplexNumber() * new ComplexNumber();
      Assert.AreEqual(0, number.Re);
      Assert.AreEqual(0, number.Im);
      number = new ComplexNumber() * new ComplexNumber(1, 2);
      Assert.AreEqual(0, number.Re);
      Assert.AreEqual(0, number.Im);
      number = new ComplexNumber(1, 2) * new ComplexNumber();
      Assert.AreEqual(0, number.Re);
      Assert.AreEqual(0, number.Im);
    }
  }
}
