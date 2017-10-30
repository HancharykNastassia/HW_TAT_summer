using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace Transliteration
{
  class DownloadOfTransliterationRules
  {
    const string TRANSLITRULESRUEN = @"C:\\Users\\SATELLITE\\HW_TAT_summer\\MegaSolution\\Transliteration\\TranslitRulesRU-EN.txt";
    const string TRANSLITRULESENRU = @"C:\\Users\\SATELLITE\\HW_TAT_summer\\MegaSolution\\Transliteration\\TranslitRulesEN-RU.txt";
    enum codes { RuEn, EnRu};
    /// <summary>
    /// This method reads the rules of transliteration from .txt files and creates a dictionary
    /// </summary>
    /// <param name="code">
    /// The number whitch helps to choose file to read
    /// </param>
    /// <returns>
    /// Dictionary to work with
    /// </returns>
    public Dictionary<string, string> CreateTransliterationDictionary (int code)
    {
      Dictionary<string, string> dictionary = new Dictionary<string, string>();
      string fileName = String.Empty;
      if (code == (int)codes.RuEn)
      {
        fileName = TRANSLITRULESRUEN;
      }
      else if(code == (int)codes.EnRu)
      {
        fileName = TRANSLITRULESENRU;
      }
      using (StreamReader readThreat = File.OpenText(fileName))
      {      
        while (!readThreat.EndOfStream)
        {
          string line = readThreat.ReadLine();
          if (readThreat.EndOfStream)
          {
            break;
          }
          string[] keyValuePair = line.Split('-');
          dictionary.Add(keyValuePair[0], keyValuePair[1]);
        }
      }
      return dictionary;
    }
  }
}