using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Stack;

namespace StackTest
{
  [TestClass]
  public class StackTest
  {
    [TestMethod]
    public void TestPush()
    {
      Stack<int> intStack = new Stack<int>();
      intStack.Push(1);
      Assert.IsTrue(intStack.Count == 1);
      intStack.Push(2);
      Assert.IsTrue(intStack.Count == 2);
    }

    [TestMethod]
    public void TestPop()
    {
      Stack<int> intStack = new Stack<int>();
      intStack.Push(1);
      intStack.Push(2);
      int actualIntValue = intStack.Pop();
      Assert.IsTrue(actualIntValue == 2);
      Assert.IsTrue(intStack.Count == 1);
      actualIntValue = intStack.Pop();
      Assert.IsTrue(actualIntValue == 1);
      Assert.IsTrue(intStack.Count == 0);
    }

    [ExpectedException(typeof(NullReferenceException))]
    [TestMethod]
    public void TestPopThrowsNullReferenceException()
    {
      Stack<int> intStack = new Stack<int>();
      int waitingForNullReferenceExeption = intStack.Pop();
    }

    [TestMethod]
    public void TestPeek()
    {
      Stack<int> intStack = new Stack<int>();
      intStack.Push(1);
      int actualIntValue = intStack.Peek();
      Assert.IsTrue(actualIntValue == 1);
      Assert.IsTrue(intStack.Count == 1);
      intStack.Push(2);
      actualIntValue = intStack.Peek();
      Assert.IsTrue(actualIntValue == 2);
      Assert.IsTrue(intStack.Count == 2);
    }

    [ExpectedException(typeof(NullReferenceException))]
    [TestMethod]
    public void TestPeekThrowsNullReferenceException()
    {
      Stack<int> intStack = new Stack<int>();
      int waitingForNullReferenceExeption = intStack.Peek();
    }

    [TestMethod]
    public void TestIsEmpty()
    {
      Stack<int> intStack = new Stack<int>();
      Assert.IsTrue(intStack.IsEmpty());
      intStack.Push(1);
      Assert.IsFalse(intStack.IsEmpty());
      int intValue = intStack.Pop();
      Assert.IsTrue(intStack.IsEmpty());
    }

    [TestMethod]
    public void TestClear()
    {
      Stack<int> intStack = new Stack<int>();
      intStack.Push(1);
      intStack.Push(2);
      intStack.Clear();
      Assert.IsTrue(intStack.IsEmpty());
    }
  }
}
