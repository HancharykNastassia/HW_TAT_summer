using System;
using System.Collections;
using System.Linq;

namespace BracketsPositionValidation
{
  public class BracketsPositionValidator
  {
    const string bracketsSymbols = "()[]{}";
    Stack bracketsStack;
    Stack closingBracketsStack;
    /// <summary>
    /// Constructor. Fullfills Stack with braskets from initial string and creates stack of closing brackets
    /// </summary>
    /// <param name="line">
    /// String which can contain bracket which positions are to validate
    /// </param>
    public BracketsPositionValidator(string line)
    {
      bracketsStack = new Stack();
      foreach (char symbol in line)
      {
        if (bracketsSymbols.Contains(symbol))
        {
          bracketsStack.Push(symbol);
        }
      }
      closingBracketsStack = new Stack();
    }

    /// <summary>
    /// Validates position of brackets.
    /// </summary>
    /// <returns>
    /// True if brackets
    /// 1) Closing bracket is of the same type as opening bracket;
    /// 2) There is no closing brackets without opening bracets of the same type;
    /// False in other cases;
    /// </returns>
    public bool ArePositionsOfBreackrtsValid()
    {
      if (bracketsStack.Count == 0)
      {
        return true;
      }
      while (bracketsStack.Count > 0)
      {
        FullfillStackOfClosingBrackets();
        if (closingBracketsStack.Count == 0 || bracketsStack.Count == 0)
        {
          return false;
        }
        if (!IsInRightOrder())
        {
          return false;
        }
      }
      return closingBracketsStack.Count == 0;
    }

    private void FullfillStackOfClosingBrackets()
    {
      while (bracketsStack.Peek().Equals(bracketsSymbols[1]) || bracketsStack.Peek().Equals(bracketsSymbols[3])
             || bracketsStack.Peek().Equals(bracketsSymbols[5]))
      {
        closingBracketsStack.Push(bracketsStack.Pop());
      }
    }

    private bool IsInRightOrder()
    {
      if (bracketsStack.Count < closingBracketsStack.Count)
      {
        return false;
      }
      while (bracketsStack.Count > 0 && (!bracketsStack.Peek().Equals(bracketsSymbols[1])
             && !bracketsStack.Peek().Equals(bracketsSymbols[3]) && !bracketsStack.Peek().Equals(bracketsSymbols[5])))
      {
        if (bracketsStack.Peek().Equals(bracketsSymbols[0]) && closingBracketsStack.Peek().Equals(bracketsSymbols[1]))
        {
          bracketsStack.Pop();
          closingBracketsStack.Pop();
          continue;
        }
        if (bracketsStack.Peek().Equals(bracketsSymbols[2]) && closingBracketsStack.Peek().Equals(bracketsSymbols[3]))
        {
          bracketsStack.Pop();
          closingBracketsStack.Pop();
          continue;
        }
        if (bracketsStack.Peek().Equals(bracketsSymbols[4]) && closingBracketsStack.Peek().Equals(bracketsSymbols[5]))
        {
          bracketsStack.Pop();
          closingBracketsStack.Pop();
          continue;
        }
        else
        {
          return false;
        }
      }
      return true;
    }
  }
}