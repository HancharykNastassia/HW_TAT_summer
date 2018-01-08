using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BracketsPositionValidation;

namespace BracketsPositionValidatorTest
{
  [TestClass]
  public class BracketsPositionValidatorTest
  {
    [TestMethod]
    public void TestArePositionsOfBreackrtsValidPositive()
    {
      string[] validInput = { "()", "[()]", "{[()][()]}", "()[]{}", "{test}", "abc", "(\\[])", String.Empty};
      foreach (string line in validInput)
      {
        Assert.IsTrue(new BracketsPositionValidator(line).ArePositionsOfBreackrtsValid());
      }
    }

    [TestMethod]
    public void TestArePositionsOfBreackrtsValidNegative()
    {
      string[] invalidInput = { "(", "[]}", "[(])", "{[][)}"};
      foreach (string line in invalidInput)
      {
        Assert.IsFalse(new BracketsPositionValidator(line).ArePositionsOfBreackrtsValid());
      }
    }
  }
}
