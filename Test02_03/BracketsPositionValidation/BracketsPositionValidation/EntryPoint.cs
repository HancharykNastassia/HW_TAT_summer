using System;

namespace BracketsPositionValidation
{
  class EntryPoint
  {
    /// <summary>
    /// Programm starts here
    /// </summary>
    /// <param name="args">
    /// Arguments of command line. Not nessessary here
    /// </param>
    static void Main(string[] args)
    {
      try
      {
        bool areBracketsPositionsValid = new BracketsPositionValidator(Console.ReadLine()).ArePositionsOfBreackrtsValid();
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex.Message);
      }

    }
  }
}
