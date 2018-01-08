using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using List;

namespace ListsTest
{
  [TestClass]
  public class SimplyConnectedListTest
  {
    [TestMethod]
    public void TestSimplyConnectedListAdd()
    {
      SimplyConnectedList<int> intList = new SimplyConnectedList<int>();
      intList.Add(6);
      Assert.IsTrue(intList.FirstNode.Element == 6);
      Assert.IsTrue(intList.Count == 1);
      intList.Add(7);
      intList.InitCurrentNode();
      Assert.IsTrue(intList.GetNext() == 7);
      Assert.IsTrue(intList.Count == 2);

      SimplyConnectedList<string> stringList = new SimplyConnectedList<string>();
      stringList.Add("a");
      Assert.IsTrue(stringList.FirstNode.Element.Equals("a"));
      Assert.IsTrue(stringList.Count == 1);
      stringList.Add("abs");
      stringList.InitCurrentNode();
      Assert.IsTrue(stringList.GetNext().Equals("abs"));
      Assert.IsTrue(stringList.Count == 2);
      stringList.Add(string.Empty);
      Assert.IsTrue(stringList.GetNext().Equals(string.Empty));
      Assert.IsTrue(stringList.Count == 3);
    }

    [TestMethod]
    public void TestSimplyConnectedListContains()
    {
      SimplyConnectedList<int> intList = new SimplyConnectedList<int>();
      intList.Add(6);
      Assert.IsTrue(intList.Contains(6));
      intList.Add(7);
      Assert.IsTrue(intList.Contains(7));
    }

    [TestMethod]
    public void TestSimplyConnectedListRemove()
    {
      SimplyConnectedList<int> intList = new SimplyConnectedList<int>();
      intList.Add(6);
      intList.Add(7);
      intList.Add(8);
      intList.Add(8);
      intList.Add(9);
      intList.Remove(7);
      Assert.IsFalse(intList.Contains(7));
      Assert.IsTrue(intList.Count == 4);
      intList.Remove(6);
      Assert.IsFalse(intList.Contains(6));
      Assert.IsTrue(intList.Count == 3);
      intList.Remove(9);
      Assert.IsFalse(intList.Contains(9));
      Assert.IsTrue(intList.Count == 2);
      intList.Remove(8);
      Assert.IsTrue(intList.Contains(8));
      Assert.IsTrue(intList.Count == 1);
    }

    [TestMethod]
    public void TestSimplyConnectedListClear()
    {
      SimplyConnectedList<int> intList = new SimplyConnectedList<int>();
      intList.Add(6);
      intList.Add(7);
      intList.Clear();
      Assert.IsTrue(intList.Count == 0);
    }

    [TestMethod]
    public void TestSimplyConnectedListAppendFirst()
    {
      SimplyConnectedList<int> intList = new SimplyConnectedList<int>();
      intList.Add(6);
      intList.AppendFirst(7);
      Assert.IsTrue(intList.FirstNode.Element.Equals(7));
    }

    [ExpectedException(typeof(NullReferenceException))]
    [TestMethod]
    public void TestSimplyConnectedListGetNextThrowsNullReferenceException()
    {
      SimplyConnectedList<int> intList = new SimplyConnectedList<int>();
      intList.GetNext();
    }
  }
}
