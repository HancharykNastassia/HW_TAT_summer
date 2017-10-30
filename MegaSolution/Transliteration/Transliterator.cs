using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace Transliteration
{
  class Transliterator
  {
    /// <summary>
    /// The method is used to transliterate line
    /// </summary>
    /// <param name="line"> The line to transliterate</param>
    /// <param name="dictionary">The dictionary used to transliterate</param>
    /// <returns> Transliterated line</returns>
    public string Transliterate(string line, Dictionary<string, string> dictionary)
    {
      foreach (var value in dictionary.Keys)
      {
        line = line.Replace(value, dictionary[value]);
      }
      return line;
    }
  }
}