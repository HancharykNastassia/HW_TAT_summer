using System;
using System.Text;

namespace PathValidation
{
  class EntryPoint
  {
    static void Main (string[] args)
    {
      try
      {
        
        Validator validator = new Validator();
        bool isValidate = validator.ValidatePath(args[0]);
        StringBuilder output = new StringBuilder(isValidate.ToString());
        Console.WriteLine(output);
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex.Message);
      }
    }
  }
}
