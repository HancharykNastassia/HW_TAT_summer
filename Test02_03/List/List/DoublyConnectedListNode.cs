using System;

namespace List
{
  public class DoublyConnectedListNode<T>
  {
    public T Element { get; set; }
    public DoublyConnectedListNode<T> NextElement { get; set; }
    public DoublyConnectedListNode<T> PreviousElement { get; set; }

    public DoublyConnectedListNode(T element)
    {
      Element = element;
    }
  }
}
