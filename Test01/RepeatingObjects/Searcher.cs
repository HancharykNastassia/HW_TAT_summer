using System;
using System.Collections.Generic;

namespace RepeatingObjects
{
  class Searcher
  {
    List<string> ListToSearchIn;
  
    public Searcher(List<string> list)
    {
      ListToSearchIn = list;
    }

    //The method counts repeating objects
    public int CountReapitings ()
    {
      int quantityOfRepeatingObjects = 0;
      List<string> checkedLines = new List<string>();
      foreach (var line in ListToSearchIn)
      {
        if (!checkedLines.Contains(line))
        {
          if (ListToSearchIn.IndexOf(line) != ListToSearchIn.LastIndexOf(line))
          {
            quantityOfRepeatingObjects++;
          }
          checkedLines.Add(line);
        }
      }
      return quantityOfRepeatingObjects;
    }
  }
}
