using System;

namespace CheckingStringToBeInt
{
  public class StringToIntConverter
  {
    string line;
    /// <summary>
    /// trivial constructor
    /// </summary>
    /// <param name="line">
    /// initial line
    /// </param>
    public StringToIntConverter(string line)
    {
      this.line = line;
    }

    /// <summary>
    /// This method convert line to integer value. The line is checked and it can be converted
    /// </summary>
    /// <returns>
    /// Returns the result of convertation in long type
    /// </returns>
    public long ConvertStringToInt()
    {
      long intNumber = 0;
      int[] values = new int[line.Length];
      Array.Copy(ConvertCharToInt(), values, values.Length);
      for (int i = 0; i < line.Length; i++)
      {
        intNumber += values[values.Length - 1 - i] * GetMultiplier(i);
      }
      return intNumber;
    }

    private int[] ConvertCharToInt()
    {
      int[] resultArray = new int[line.Length];
      for (int i = 0; i < resultArray.Length; i++)
      {
        switch (line[i])
        {
          case '0':
            resultArray[i] = 0;
            break;
          case '1':
            resultArray[i] = 1;
            break;
          case '2':
            resultArray[i] = 2;
            break;
          case '3':
            resultArray[i] = 3;
            break;
          case '4':
            resultArray[i] = 4;
            break;
          case '5':
            resultArray[i] = 5;
            break;
          case '6':
            resultArray[i] = 6;
            break;
          case '7':
            resultArray[i] = 7;
            break;
          case '8':
            resultArray[i] = 8;
            break;
          case '9':
            resultArray[i] = 9;
            break;
          case '.':
            resultArray[i] = 10;
            break;
          case ',':
            resultArray[i] = 10;
            break;
        }
      }
      return resultArray;
    }

    private long GetMultiplier(int power)
    {
      long multiplier = 1;
      for (int i = 1; i <= power; i++)
      {
        multiplier *= 10;
      }
      return multiplier;
    }

    private int[] RemoveDeviders(int[] values)
    {
      int[] resultArray = new int[values.Length - CountDeviders(values)];
      for (int i = 0; i < resultArray.Length; i++)
      {
        if (values[i] == 10)
        {
          int temp = values[i];
          values[i] = values[i + 1];
          values[i + 1] = temp;
        }
        resultArray[i] = values[i];
      }
      return resultArray;
    }

    private int CountDeviders(int[] values)
    {
      int numberOfDeviders = 0;
      foreach (int number in values)
      {
        if (number == 10)
        {
          numberOfDeviders++;
        }
      }
      return numberOfDeviders;
    }
  }
}
