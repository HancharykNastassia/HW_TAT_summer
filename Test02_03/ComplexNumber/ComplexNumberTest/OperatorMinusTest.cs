﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ComplexNumberNs;

namespace ComplexNumberTest
{
  [TestClass]
  public class OperatorMinusTest
  {
    [TestMethod]
    public void TestOperatorMinus()
    {
      ComplexNumber number = new ComplexNumber(1, 0) - new ComplexNumber(0, 1);
      Assert.AreEqual(1, number.Re);
      Assert.AreEqual(-1, number.Im);
      number = new ComplexNumber() - new ComplexNumber();
      Assert.AreEqual(0, number.Re);
      Assert.AreEqual(0, number.Im);
      number = new ComplexNumber(0, -1) - new ComplexNumber(-2, 0);
      Assert.AreEqual(2, number.Re);
      Assert.AreEqual(-1, number.Im);
      number = new ComplexNumber(0, -1.0) - new ComplexNumber(2.1, 0);
      Assert.AreEqual(-2.1, number.Re);
      Assert.AreEqual(-1, number.Im);
      number = new ComplexNumber(6, 5) - new ComplexNumber(5, 4);
      Assert.AreEqual(1, number.Re);
      Assert.AreEqual(1, number.Im);
      number = new ComplexNumber(4, -1.0) - new ComplexNumber(2, 1);
      Assert.AreEqual(2, number.Re);
      Assert.AreEqual(-2, number.Im);
    }
  }
}
