using System;
using System.Collections.Generic;

namespace LikeDOMObject
{
  /// <summary>
  /// This class parses string made after XML file was read into elements that are included in XML fle
  /// </summary>
  public class DOMParser
  {
    string readFromXML;

    /// <summary>
    /// Trivial constructor
    /// </summary>
    /// <param name="input">
    /// String made after XML file was read. This string is cut during the program works
    /// </param>
    public DOMParser(string input)
    {
      readFromXML = input;
    }

    /// <summary>
    /// This method creates new exemplar of Element and fullfills its fields
    /// </summary>
    /// <returns>
    /// Fullfilled exemplar of Element
    /// </returns>
    public Element MakeElement()
    {
      Element element = new Element();
      element.Tag = readFromXML.Substring(readFromXML.IndexOf("<") + 1, readFromXML.IndexOf(">") - 1);
      string[] workStrings = CutString(element.Tag); 
      foreach (string line in workStrings)
      {
        if (line.StartsWith("<"))
        {
          element.ChildrenElements.Add(new DOMParser(line).MakeElement());
        }
        else
        {
          element.Text = line;
        }
      }
      return element;
    }

    //Cuts the string with values of tags
    private string[] CutString(string tag)
    {
      string separator1 = "<" + tag + ">";
      string separator2 = "</" + tag + ">";
      string[] separator = { separator1, separator2 };
      return readFromXML.Split(separator, StringSplitOptions.RemoveEmptyEntries);
    }
  }
}
