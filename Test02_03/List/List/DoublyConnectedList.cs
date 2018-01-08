using System;

namespace List
{
  /// <summary>
  /// This class represetns Doubly Connected List
  /// </summary>
  /// <typeparam name="T">Type of data saved in the list. It can be any type</typeparam>
  public class DoublyConnectedList<T>
  {
    DoublyConnectedListNode<T> FirstNode { get; set; }
    DoublyConnectedListNode<T> LastNode { get; set; }
    DoublyConnectedListNode<T> currentNode;
    public int Count { get; set; }

    /// <summary>
    /// Initiates current node
    /// </summary>
    public void InitCurrentNode()
    {
      currentNode = FirstNode;
    }

    /// <summary>
    /// Gets next node
    /// </summary>
    /// <returns>Element of next Node</returns>
    public T GetNext()
    {
      currentNode = currentNode.NextElement;
      return currentNode.Element; 
    }

    /// <summary>
    /// Gets previous node
    /// </summary>
    /// <returns>Element of previous Node</returns>
    public T GetPrevious()
    {
      currentNode = currentNode.PreviousElement;
      return currentNode.Element;
    }

    /// <summary>
    /// Add a new node to the talil of list
    /// </summary>
    /// <param name="newElement">Element to add</param>
    public void Add(T newElement)
    {
      DoublyConnectedListNode<T> newNode = new DoublyConnectedListNode<T>(newElement);
      if (FirstNode == null)
      {
        FirstNode = newNode;
      }
      else
      {
        newNode.PreviousElement = LastNode;
        LastNode.NextElement = newNode;
      }
      LastNode = newNode;
      Count++;
    }

    /// <summary>
    /// Removes first node equal to element to remove
    /// </summary>
    /// <param name="element">Element to remove</param>
    public void Remove(T element)
    {
      InitCurrentNode();
      while (currentNode != null)
      {
        if (currentNode.Element.Equals(element))
        {
          if (currentNode.PreviousElement != null)
          {

            currentNode.PreviousElement.NextElement = currentNode.NextElement;
            currentNode.NextElement.PreviousElement = currentNode.PreviousElement;
            if (currentNode.NextElement == null)
            {
              LastNode = currentNode.PreviousElement;
            }
          }
          else
          {
            FirstNode = FirstNode.NextElement;
            if (FirstNode == null)
            {
              LastNode = null;
            }
          }
          Count--;
          break;
        }
        currentNode = currentNode.NextElement;
      }
    }

    /// <summary>
    /// Deletes all nodes from list
    /// </summary>
    public void Clear()
    {
      InitCurrentNode();
      DoublyConnectedListNode<T> newNode = currentNode.NextElement;
      while (!currentNode.Equals(LastNode))
      {
        currentNode = null;
        currentNode = newNode;
        newNode = currentNode.NextElement;
      }
      newNode = null;
      Count = 0;
    }

    /// <summary>
    /// Checks if list contains a node
    /// </summary>
    /// <param name="element">Node to search for</param>
    /// <returns>True if list contains such node and False if it doesn't</returns>
    public bool Contains(T element)
    {
      InitCurrentNode();
      while (currentNode != null)
      {
        if (currentNode.Element.Equals(element))
        {
          return true;
        }
        currentNode = currentNode.NextElement;
      }
      return false;
    }

    /// <summary>
    /// Adds a node in the head of list
    /// </summary>
    /// <param name="element">Node to add</param>
    public void AppendFirst(T element)
    {
      DoublyConnectedListNode<T> newNode = new DoublyConnectedListNode<T>(element);
      newNode.NextElement = FirstNode;
      FirstNode = newNode;
      Count++;
    }
  }
}
