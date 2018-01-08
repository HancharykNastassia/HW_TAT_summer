using System;

namespace List
{
  public class SimplyConnectedListNode<T>
  {
    public T Element { get; set; }
    public SimplyConnectedListNode<T> NextElement { get; set; }

    public SimplyConnectedListNode(T element)
    {
      Element = element;
    }
  }
}
