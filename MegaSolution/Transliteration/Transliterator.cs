using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace Transliteration
{
  class Transliterator
  {
    public string Transliterate(string line, Dictionary<string, string> dictionary)
    {
      foreach(var value in dictionary.Keys)
      {
        line = line.Replace(value, dictionary[value]);
      }
      return line;
    }
  }
}