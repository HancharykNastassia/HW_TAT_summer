using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PathValidation;

namespace TestPathValidation
{
  [TestClass]
  public class NegativePathValidationTestClass
  {
    [TestMethod]
    public void NegativeTestMethod1()
    {
      Assert.IsFalse(new Validator().ValidatePath(":\\"));
    }

    [TestMethod]
    public void NegativeTestMethod2() { Assert.IsFalse(new Validator().ValidatePath("\\")); }
    [TestMethod] public void NegativeTestMethod3() { Assert.IsFalse(new Validator().ValidatePath("\\\\dot.\\test.txt")); }
    [TestMethod] public void NegativeTestMethod4() { Assert.IsFalse(new Validator().ValidatePath(".\\quest?.txt")); }
    [TestMethod] public void NegativeTestMethod5() { Assert.IsFalse(new Validator().ValidatePath("..\\space .txt")); }
    [TestMethod] public void NegativeTestMethod6() { Assert.IsFalse(new Validator().ValidatePath("D:\\space \\txt.t")); }
    [TestMethod] public void NegativeTestMethod7() { Assert.IsFalse(new Validator().ValidatePath("D:\\COM9\\test.txt")); }
    [TestMethod] public void NegativeTestMethod8() { Assert.IsFalse(new Validator().ValidatePath("\\\\test\\LPT1.txt")); }
    [TestMethod] public void NegativeTestMethod9() { Assert.IsFalse(new Validator().ValidatePath("\\\\..\\con.txt")); }
    [TestMethod] public void NegativeTestMethod10() { Assert.IsFalse(new Validator().ValidatePath("NuLl\\test.txt")); }
    [TestMethod] public void NegativeTestMethod11() { Assert.IsFalse(new Validator().ValidatePath("aUx.txt")); }
    [TestMethod] public void NegativeTestMethod12() { Assert.IsFalse(new Validator().ValidatePath(String.Empty)); }
    [TestMethod] public void NegativeTestMethod13() { Assert.IsFalse(new Validator().ValidatePath("\\\\te:st\\colon.txt")); }
    [TestMethod] public void NegativeTestMethod14() { Assert.IsFalse(new Validator().ValidatePath("\\\\.tx/t")); }

  }
}
