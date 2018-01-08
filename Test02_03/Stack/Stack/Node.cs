using System;

namespace Stack
{
  /// <summary>
  /// Node which can be kept in Stack 
  /// </summary>
  /// <typeparam name="T">Type of data saved in the list. It can be of any type</typeparam>
  public class Node<T>
  {
    public T Element { get; set; }
    public Node<T> NextElement { get; set; }

    public Node(T element)
    {
      Element = element;
    }
  }
}
