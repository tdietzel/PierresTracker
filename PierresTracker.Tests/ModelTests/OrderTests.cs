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
      Order newOrder = new Order("", "", 0, "");

      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }
    [TestMethod] // Test #2
    public void GetOrderTitle_ReturnsTitle_String()
    {
      string title = "Suzies Order";
      Order newOrder = new Order(title, "", 0, "");
      string result = newOrder.Title;
      
      Assert.AreEqual(title, result);
    }
    [TestMethod] // Test #3
    public void GetOrderDescription_ReturnsDescription_String()
    {
      string description = "1 loaf of bread.";
      Order newOrder = new Order("Suzies Order", description, 0, "");
      string result = newOrder.Description;

      Assert.AreEqual(description, result);
    }
    [TestMethod] // Test #4
    public void GetOrderPrice_ReturnsPrice_Int()
    {
      int price = 5;
      Order newOrder = new Order("", "", 5, "");
      int result = newOrder.Price;

      Assert.AreEqual(price, result);
    }
    [TestMethod] // Test #5
    public void GetOrderDate_ReturnsDate_String()
    {
      string date = "1/20/24";
      Order newOrder = new Order("", "", 0, date);
      string result = newOrder.Date;
      
      Assert.AreEqual(date, result);
    }
  }
}