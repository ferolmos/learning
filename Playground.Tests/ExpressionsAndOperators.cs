using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Playground.Tests
{
  /// <summary>
  /// Summary description for ExpressionsAndOperators
  /// </summary>
  [TestClass]
  public class ExpressionsAndOperators
  {
    public ExpressionsAndOperators()
    {
      //
      // TODO: Add constructor logic here
      //
    }

    /// <summary>
    ///Gets or sets the test context which provides
    ///information about and functionality for the current test run.
    ///</summary>
    public TestContext TestContext { get; set; }

    #region Additional test attributes
    //
    // You can use the following additional attributes as you write your tests:
    //
    // Use ClassInitialize to run code before running the first test in the class
    // [ClassInitialize()]
    // public static void MyClassInitialize(TestContext testContext) { }
    //
    // Use ClassCleanup to run code after all tests in a class have run
    // [ClassCleanup()]
    // public static void MyClassCleanup() { }
    //
    // Use TestInitialize to run code before running each test 
    // [TestInitialize()]
    // public void MyTestInitialize() { }
    //
    // Use TestCleanup to run code after each test has run
    // [TestCleanup()]
    // public void MyTestCleanup() { }
    //
    #endregion

    [TestMethod]
    public void PositiveValueOf()
    {
      const int number = 5;

      Assert.AreEqual(5, +number);
    }

    [TestMethod]
    public void PositiveValueOfNegative()
    {

      var number = -5;

      Assert.AreEqual(-5, +number);
    }

    [TestMethod]
    public void NegativeValueOf()
    {

      var number = 5;

      Assert.AreEqual(-5, -number);
    }

    [TestMethod]
    public void NegativeValueOfNegative()
    {

      var number = -5;

      Assert.AreEqual(5, -number);
    }
  }
}
