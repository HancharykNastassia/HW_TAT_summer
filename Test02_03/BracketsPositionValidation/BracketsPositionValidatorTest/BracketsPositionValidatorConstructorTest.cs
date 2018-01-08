using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BracketsPositionValidation;

namespace BracketsPositionValidatorTest
{
  [TestClass]
  public class BracketsPositionValidatorConstructorTest
  {
    [ExpectedException(typeof(NullReferenceException))]
    [TestMethod]
    public void BracketsPositionValidatorConstructorThrowsNullReferenceException()
    {
      BracketsPositionValidator validator = new BracketsPositionValidator(null);
    }
  }
}
