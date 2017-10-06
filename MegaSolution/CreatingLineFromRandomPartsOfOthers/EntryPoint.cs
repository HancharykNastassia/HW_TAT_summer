using System;

namespace CreatingLineFromRandomPartsOfOthers
{
  class EntryPoint
  {
    const string FOREXIT = "Press any key for exit.";
    static void Main(string[] args)
    {
      try
      {
        string[] lines = new Inputter().InputLines();
        string newLine = new NewLineCreator().CreateNewLine(lines);
        Console.WriteLine("First line:");
        Console.WriteLine(lines[0]);
        Console.WriteLine("Second Line:");
        Console.WriteLine(lines[1]);
        Console.WriteLine("Result Line:");
        Console.WriteLine(newLine);
        Console.WriteLine(FOREXIT);
        Console.ReadKey();
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex.Message);
        Console.WriteLine(FOREXIT);
        Console.ReadKey();
      }
    }
  }
}