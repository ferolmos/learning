using System;
using System.Reflection.Emit;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Playground.Tests
{
  [TestClass]
  public class ByTypeByReference
  {

    [TestMethod]
    public void TestValueType()
    {

      var number = 17878;

      var otherNumber = number;

      otherNumber = 0;

      Assert.AreEqual(17878, number);
      Assert.AreEqual(0, otherNumber);
    }

    [TestMethod]
    public void TestValueTypeString()
    {

      String message = "I have a dream";

      var copy = message;

      copy = "I have nothing";

      Assert.AreEqual("I have a dream", message);
    }


    [TestMethod]
    public void TestByRefrence()
    {

      var person = new Person(11,"James");

      var personCopy = person;

      personCopy.Name = "Thomas";

      Assert.AreEqual("Thomas", person.Name);
      Assert.AreEqual("Thomas", personCopy.Name);
    }

    [TestMethod]
    public void TestRefParameteres()
    {
      var number = 56;
      var message = string.Empty;

      Person.RepitText(ref number, ref message);

      const int expectedNumber = 5;
      const string expectedMessage = "Please send me something to say.";

      Assert.AreEqual(expectedNumber, number);
      Assert.AreEqual(expectedMessage, message);
      //no mater if types are value type or refrence type.
    }

    [TestMethod]
    public void TestByValue()
    {
      var position = new Location(12,57,"North");

      var positionCopy = position;

      positionCopy.Latitude = 33;
      positionCopy.Direction = "South";

      Assert.AreEqual(57, position.Latitude);
      Assert.AreEqual("North", position.Direction);

      Assert.AreEqual(33, positionCopy.Latitude);
      Assert.AreEqual("South", positionCopy.Direction);

    }
  }
}
