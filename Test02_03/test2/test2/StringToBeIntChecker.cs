using System;

namespace CheckingStringToBeInt
{
  public class StringToBeIntChecker
  {
    string line;
    /// <summary>
    /// trivial constructor
    /// </summary>
    /// <param name="line">
    /// initial line
    /// </param>
    public StringToBeIntChecker(string line)
    {
      this.line = line;
    }
    /// <summary>
    /// This method checkes if line can be converted to integer
    /// </summary>
    /// <returns>
    /// Returns true if it can be converted to int and false if it can't
    /// </returns>
    public bool IsStringInteger()
    {
      if (line.Length > Int64.MaxValue.ToString().Length)
      {
        return false;
      }

      char zeroCharValue = '0';
      char nineCharValue = '9';
      int dotCounter = 0;
      int commaCounter = 0;
      foreach (char symbol in line)
      {
        if (symbol < zeroCharValue || symbol > nineCharValue)
        {
          if (symbol.Equals('.'))
          {
            dotCounter++;
          }
          else if (symbol.Equals(','))
          {
            commaCounter++;
          }
          else
          {
            return false;
          }
        }
      }
      if (line.StartsWith(",") || line.StartsWith("."))
      {
        return false;
      }
      if ((dotCounter + commaCounter) > 1)
      {
        int lastDevider = Math.Max(line.LastIndexOf('.'), line.LastIndexOf(','));
        string tempString = line.Substring(lastDevider + 1);
        foreach (char symbol in tempString)
        {
          if (!symbol.Equals(zeroCharValue))
          {
            return false;
          }
        }
      }
      if ((dotCounter + commaCounter) > 2)
      {
        return false;
      }
      return !line.Contains(" ");
    }
  }
}
