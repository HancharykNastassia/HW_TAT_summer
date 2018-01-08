using System;
using System.IO;

namespace LikeDOMObject
{
  class EntryPoint
  {
    const string FILEPATH = @"test.XML";

    /// <summary>
    /// Program starts here
    /// </summary>
    /// <param name="args">
    /// Arguments of command line. They are not nessessary here
    /// </param>
    static void Main (string[] args)
    {
      string input = String.Empty;
      using (StreamReader stream = File.OpenText(FILEPATH))
      {
        input += stream.ReadLine();
      }
      Element element = new DOMParser(input).MakeElement();
    }
  }
}
