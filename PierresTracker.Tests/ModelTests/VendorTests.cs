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

    [TestMethod]
    public void VendorConstructor_CreatesAVendorConstructor_Vendor()
    {
      Vendor newVendor = new Vendor("");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }
    [TestMethod]
    public void GetsVendorName_ReturnsName_String()
    {
      string name = "Suzie's Cafe";
      Vendor newVendor = new Vendor("Suzie's Cafe");
      string result = newVendor.Name;
      Assert.AreEqual(name, result);
    }
    [TestMethod]
    public void GetsVendorId_ReturnsId_Int()
    {
      Vendor newVendor = new Vendor("Suzie's Cafe");
      Assert.AreEqual(1, newVendor.Id);
    }
  }
}