using System;

namespace CreatingLineFromRandomPartsOfOthers
{
  class Inputter
  {
    const string FIRSTINSTRUCTION = "Enter the first line, please";
    const string SECONDINSTRUCTION = "Enter the second line, please";
    const string ASKFORREINPUT = "Pease, repeat your input";
    bool successInput;
    public string[] InputLines(string[] lines)
    {
      successInput = false;
      while (!successInput)
      {
        try
        {
          successInput = true;
          Console.WriteLine(FIRSTINSTRUCTION);
          lines[0] = Console.ReadLine();
          Console.WriteLine(SECONDINSTRUCTION);
          lines[1] = Console.ReadLine();
        }
        catch (Exception ex)
        {
          Console.WriteLine(ex.Message);
          successInput = false;
        }
      }
      return lines;
    }
  }
}