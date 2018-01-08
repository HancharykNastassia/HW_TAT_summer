using System;

namespace CheckingStringToBeInt
{
  class EntryPoint
  {
    const string INPUTLINE = "Input any line";
    const string NOTINTEGER = "It is not integer";
    /// <summary>
    /// Program starts here
    /// </summary>
    /// <param name="args">
    /// command line args. Are not nessessary here
    /// </param>
    static void Main(string[] args)
    {
      try
      {
        Console.WriteLine(INPUTLINE);
        string input = Console.ReadLine();
        StringToBeIntChecker checker = new StringToBeIntChecker(input);
        if (checker.IsStringInteger())
        {
          Console.WriteLine(new StringToIntConverter(input).ConvertStringToInt());
        }
        else
        {
          Console.WriteLine(NOTINTEGER);
        }
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex.Message);
      }
    }
  }
}
