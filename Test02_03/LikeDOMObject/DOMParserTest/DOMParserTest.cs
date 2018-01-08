using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LikeDOMObject;

namespace DOMParserTest
{
  [TestClass]
  public class DOMParserTest
  {
    [ExpectedException(typeof(NullReferenceException))]
    [TestMethod]
    public void TestConstructorThrowsNullReferenceExeption()
    {
      DOMParser parser = new DOMParser(null);
    }

    [TestMethod]
    public void TestMakeElement()
    {
      Element expectedElement = new Element();
      expectedElement.Tag = "name";
      expectedElement.Text = "somename";
      Element element = new DOMParser("<name>somename</name>").MakeElement();
      Assert.AreEqual(expectedElement.Tag, element.Tag);
      Assert.AreEqual(expectedElement.Text, element.Text);
      CollectionAssert.AreEqual(expectedElement.ChildrenElements, element.ChildrenElements);
    }
  }
}
