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
    public Dictionary<string, string> FillDictionary (int code)
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
      if (File.Exists(fileName))
      {
        StreamReader readThreat = new StreamReader(fileName, Encoding.Default);
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
        readThreat.Close();
        }
      return dictionary;
    }
  }
}