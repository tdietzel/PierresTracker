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
      string name= "Suzie's Cafe";
      string description = "The Cafe on 3rd street in testing city";
      Vendor newVendor = new Vendor(name, description);
      string result = newVendor.Description;

      Assert.AreEqual(description, result);
    }
    [TestMethod]  // Test #3
    public void GetsVendorId_ReturnsId_Int()
    {
      string description = "The Cafe on 3rd street in testing city";
      Vendor newVendor = new Vendor("Suzie's Cafe", description);

      Assert.AreEqual(1, newVendor.Id);
    }
    [TestMethod]  // Test #4
    public void AddsVendorToList_ReturnsVendorList_List()
    {
      string description = "The Cafe on 3rd street in testing city";
      Vendor newVendor = new Vendor("Suzie's Cafe", description);
      List<Vendor> allVendors = new List<Vendor> { newVendor };

      Assert.AreEqual(newVendor, allVendors[0]);
    }
  }
}