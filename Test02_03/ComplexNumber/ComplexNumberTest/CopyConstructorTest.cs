using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ComplexNumberNs;

namespace ComplexNumberTest
{
  [TestClass]
  public class CopyConstructorTest
  {
    [ExpectedException(typeof(NullReferenceException))]
    [TestMethod]
    public void TestCopyConstructorThrowsNullReferenceException()
    {
      new ComplexNumber(null);
    }
  }
}
