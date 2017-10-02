using System;

namespace CreatingArrayFromElementsOfOthers
{
  class EntryPoint
  {
    const string FOREXIT = "Press any key for exit";
    static void Main(string[] args)
    {
      try
      {
        double[][] doubleArrays = new Inputter().GetArrays();
        double[] resultDoubleArray = new CraetingArray().CreateArray(doubleArrays);
        Console.WriteLine("Result Array:");
        foreach (int i in resultDoubleArray)
        {
          Console.Write(resultDoubleArray[i] + " ");
        }
        Console.WriteLine(String.Empty);
        Console.WriteLine(FOREXIT);
        Console.ReadKey();
      }
      catch(Exception ex)
      {
        Console.WriteLine(ex.Data.ToString() + ex.Message);
        Console.WriteLine(FOREXIT);
        Console.ReadKey();
      }
    }
  }
}