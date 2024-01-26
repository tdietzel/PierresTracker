using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresTracker.Models;

namespace PierresTracker.Tests
{
  [TestClass]
  public class OrderTests
  {
    [TestMethod] // Test #1
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("");

      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }
    [TestMethod] // Test #2
    public void GetOrderTitle_ReturnsTitle_String()
    {
      string suziesOrder = "bread";
      Order newOrder = new Order(suziesOrder);
      string result = newOrder.Title;
      
      Assert.AreEqual(suziesOrder, result);
    }
  }
}