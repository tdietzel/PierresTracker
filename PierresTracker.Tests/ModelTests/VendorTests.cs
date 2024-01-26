using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresTracker.Models;

namespace PierresTracker.Tests
{
  [TestClass]
  public class VendorTests : IDisposable
  {

    public void Dispose()
    {
      Vendor.ResetNextId();
      Vendor.ClearAll();
    }

    [TestMethod] // Test #1
    public void VendorConstructor_CreatesAVendorConstructor_Vendor()
    {
      Vendor newVendor = new Vendor("", "");

      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }
    [TestMethod] // Test #2
    public void GetsVendorName_ReturnsName_String()
    {
      string name = "Suzie's Cafe";
      Vendor newVendor = new Vendor("Suzie's Cafe", "");
      string result = newVendor.Name;

      Assert.AreEqual(name, result);
    }
    [TestMethod]  // Test #5
    public void GetsVendorDescription_ReturnsDescription_String()
    {
      string description = "The Cafe on 3rd street in testing city";
      Vendor newVendor = new Vendor("Name", description);
      string result = newVendor.Description;

      Assert.AreEqual(description, result);
    }
    [TestMethod]  // Test #3
    public void GetsVendorId_ReturnsId_Int()
    {
      Vendor newVendor = new Vendor("Name", "Description");

      Assert.AreEqual(1, newVendor.Id);
    }
    [TestMethod]  // Test #4
    public void AddsVendorToList_ReturnsVendorList_List()
    {
      Vendor newVendor = new Vendor("Name", "Description");
      List<Vendor> allVendors = new List<Vendor> { newVendor };

      Assert.AreEqual(newVendor, allVendors[0]);
    }
    [TestMethod] // Test #6
    public void CreatesNewListOfOrders_ReturnsOrdersInList_List()
    {
      Vendor newVendor = new Vendor("", "");
      Order newOrder = new Order("Name", "Description", 0, "Date");
      newVendor.Orders.Add(newOrder);

      Assert.AreEqual(newOrder, newVendor.Orders[0]);
    }
    [TestMethod] // Test #7
    public void GetAllVendors_ReturnsVendorInstances_List()
    {
      Vendor firstVendor = new Vendor("", "");
      Vendor anotherVendor = new Vendor("", "");

      List<Vendor> newVendors = new List<Vendor> { firstVendor, anotherVendor };
      List<Vendor> allVendors = Vendor.GetAll();
      
      CollectionAssert.AreEqual(newVendors, allVendors);
    }
  }
}