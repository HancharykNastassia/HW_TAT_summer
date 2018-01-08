using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PathValidation;

namespace TestPathValidation
{
  [TestClass]
  public class PositivePathValidationTestClass
  {
    [TestMethod] public void PositiveTestMethod1() { Assert.IsTrue(new Validator().ValidatePath("c:\\")); }
    [TestMethod] public void PositiveTestMethod2() { Assert.IsTrue(new Validator().ValidatePath(".\\")); }
    [TestMethod] public void PositiveTestMethod3() { Assert.IsTrue(new Validator().ValidatePath("..\\")); }
    [TestMethod] public void PositiveTestMethod4() { Assert.IsTrue(new Validator().ValidatePath("c:\\")); }
    [TestMethod] public void PositiveTestMethod5() { Assert.IsTrue(new Validator().ValidatePath("D:\\a")); }
    [TestMethod] public void PositiveTestMethod6() { Assert.IsTrue(new Validator().ValidatePath("\\\\src")); }
    [TestMethod] public void PositiveTestMethod7() { Assert.IsTrue(new Validator().ValidatePath("D:\\.\\")); }
    [TestMethod] public void PositiveTestMethod8() { Assert.IsTrue(new Validator().ValidatePath("D:\\..\\")); }
    [TestMethod] public void PositiveTestMethod9() { Assert.IsTrue(new Validator().ValidatePath("\\\\.\\")); }
    [TestMethod] public void PositiveTestMethod10() { Assert.IsTrue(new Validator().ValidatePath("\\\\..\\")); }
    [TestMethod] public void PositiveTestMethod11() { Assert.IsTrue(new Validator().ValidatePath("e:\\..\\test.txt")); }
    [TestMethod] public void PositiveTestMethod12() { Assert.IsTrue(new Validator().ValidatePath("\\\\..\\.txt")); }
    [TestMethod] public void PositiveTestMethod13() { Assert.IsTrue(new Validator().ValidatePath("\\\\.txt")); }
    [TestMethod] public void PositiveTestMethod14() { Assert.IsTrue(new Validator().ValidatePath("\\\\..\\test.CON")); }
    [TestMethod] public void PositiveTestMethod15() { Assert.IsTrue(new Validator().ValidatePath("aaa")); }
  }
}
