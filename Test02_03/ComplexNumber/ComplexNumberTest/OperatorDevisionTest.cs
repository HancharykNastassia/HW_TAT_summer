using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ComplexNumberNs;

namespace ComplexNumberTest
{
  [TestClass]
  public class OperatorDevisionTest
  {
    [ExpectedException(typeof(DivideByZeroException))]
    [TestMethod]
    public void TestOperatorDevisionThrows()
    {
      ComplexNumber number = new ComplexNumber(1, 1) / new ComplexNumber();
    }
  }
}
