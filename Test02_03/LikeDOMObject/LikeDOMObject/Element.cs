using System;
using System.Collections.Generic;

namespace LikeDOMObject
{
  /// <summary>
  /// This class represents elements of XML file
  /// </summary>
  public class Element
  {
    string tag;
    string text = String.Empty;
    List<Element> childrenElements;
    public string Tag
    {
      get
      {
        return tag;
      }
      set
      {
        tag = value;
      }
    }
    public string Text
    {
      get
      {
        return text;
      }
      set
      {
        text = value;
      }
    }
    public List<Element> ChildrenElements
    {
      get
      {
        return childrenElements;
      }
      set
      {
        childrenElements.AddRange(value);
      }
    }
  }
}
