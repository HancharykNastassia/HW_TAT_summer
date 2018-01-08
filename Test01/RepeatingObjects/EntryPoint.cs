using System;
using System.Collections.Generic;
using System.Text;

namespace RepeatingObjects
{
  class EntryPoint
  {
    static void Main (string[] args)
    {
      const int MaxSizeOfList = 100;
      List<string> listOfStrings = new List<string>();
      bool stop = false;
      do
      {
        string inputLine = Console.ReadLine();
        if (inputLine.Equals(String.Empty))
        {
          stop = true;
        }
        else
        {
          listOfStrings.Add(inputLine);
        }
        if (listOfStrings.Capacity == MaxSizeOfList)
        {
          stop = true;
        }
      }
      while (!stop);
      Searcher searcher = new Searcher(listOfStrings);
      int quantityOfRepeatings = searcher.CountReapitings();
      StringBuilder output = new StringBuilder(quantityOfRepeatings + " lines are duplicate");
      Console.WriteLine(output);
      Console.WriteLine("Press any key for exit");
      Console.ReadLine();
    }
  }
}
