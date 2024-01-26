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
      Order newOrder = new Order("", "");

      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }
    [TestMethod] // Test #2
    public void GetOrderTitle_ReturnsTitle_String()
    {
      string title = "Suzies Order";
      Order newOrder = new Order(title, "");
      string result = newOrder.Title;
      
      Assert.AreEqual(title, result);
    }
    [TestMethod] // Test #3
    public void GetOrderDescription_ReturnsDescription_String()
    {
      string description = "1 loaf of bread.";
      Order newOrder = new Order("Suzies Order", description);
      string result = newOrder.Description;
      Assert.AreEqual(description, result);
    }
  }
}