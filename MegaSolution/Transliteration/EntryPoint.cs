﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace Transliteration
{
  class EntryPoint
  {
    const string FOREXIT = "Press any key for exit.";
    const string INSTRUCTIONLINE = "Enter a line in russian please";
    const string FIRSTLINE = "Line after RuEn transliteration: ";
    const string SECONDLINE = "Line after EnRu transliteration: ";

    /// <summary>
    /// The programm starts here.
    /// </summary>
    /// <param name="args"></param>
    static void Main(string[] args)
    {
      try
      {
        Dictionary<string, string> RuEnDictionary = new DownloadOfTransliterationRules().
                                                    CreateTransliterationDictionary(dictionaryCode.RuEnCode);
        Dictionary<string, string> EnRuDictionary = new DownloadOfTransliterationRules().
                                                    CreateTransliterationDictionary(dictionaryCode.EnRuCode);
        Console.WriteLine(INSTRUCTIONLINE);
        string line = Console.ReadLine();
        string lineAfterRuEnTransliteration = new Transliterator().Transliterate(line, RuEnDictionary);
        string LineAfterEnRuTransliteration = new Transliterator().
                                                     Transliterate(lineAfterRuEnTransliteration, EnRuDictionary);
        StringBuilder output = new StringBuilder(FIRSTLINE + lineAfterRuEnTransliteration + "\n" +
                                                 SECONDLINE + LineAfterEnRuTransliteration);
        Console.WriteLine(output);
        Console.WriteLine(FOREXIT);
        Console.ReadKey();
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex.Message);
        Console.WriteLine(FOREXIT);
        Console.ReadKey();
      }
    }
  }
}