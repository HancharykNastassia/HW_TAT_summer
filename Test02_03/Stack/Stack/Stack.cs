using System;

namespace Stack
{
  /// <summary>
  /// This class represetns Stack
  /// </summary>
  /// <typeparam name="T">Type of data saved in the list. It can be of any type</typeparam>
  public class Stack<T>
  {
    Node<T> topElement;
    public int Count { get; set; }

    /// <summary>
    /// This method pushes some value to the top of stack
    /// </summary>
    /// <param name="value">Value to push</param>
    public void Push (T value)
    {
      Node<T> newNode = new Node<T>(value);
      newNode.NextElement = topElement;
      topElement = newNode;
      Count++;
    }

    /// <summary>
    /// This method extracts object from the top of stack and removes it from stack 
    /// </summary>
    /// <returns>Object from the top of stack or throws NullReferenceException if stack is empty</returns>
    public T Pop()
    {
      if (Count > 0)
      {
        T valueToReturn = topElement.Element;
        topElement = topElement.NextElement;
        Count--;
        return valueToReturn;
      }
      else
      {
        throw new NullReferenceException();
      }
    }

    /// <summary>
    /// This method extracts object from the top of stack without its removing
    /// </summary>
    /// <returns>Object from the top of stack or throws NullReferenceException if stack is empty</returns>
    public T Peek()
    {
      if (Count > 0)
      {
        return topElement.Element;
      }
      else
      {
        throw new NullReferenceException();
      }
    }

    /// <summary>
    /// This method checkes if stack is empty
    /// </summary>
    /// <returns>True if stack empty and False if it is not empty</returns>
    public bool IsEmpty()
    {
      return Count == 0;
    }

    /// <summary>
    /// This method removes all objects from stack
    /// </summary>
    public void Clear()
    {
      Node<T> currentValue;
      while(Count > 0)
      {
        currentValue = topElement.NextElement;
        topElement = null;
        topElement = currentValue;
        Count--;
      }
    }
  }
}
