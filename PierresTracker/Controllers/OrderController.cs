using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using PierresTracker.Models;

namespace PierresTracker.Controllers
{
  public class OrderController : Controller
  {
    [HttpGet("/vendors/{id}/orders")]
    public ActionResult Index(int id)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();

      Vendor selectedVendor = Vendor.Find(id);
      List<Order> vendorOrders = selectedVendor.Orders;

      model.Add("vendor", selectedVendor);
      model.Add("orders", vendorOrders);

      return View(model);
    }

    [HttpGet("/vendors/{id}/orders/new")]
    public ActionResult Create(int id)
    {
      Vendor selectedVendor = Vendor.Find(id);
      return View(selectedVendor);
    }
    
    [HttpPost("/vendors/{id}/orders")]
    public ActionResult Show(int id, string title, string description, int price, string date)
    {
      Vendor selectedVendor = Vendor.Find(id);
      
      Order newOrder = new Order(title, description, price, date);
      selectedVendor.Orders.Add(newOrder);
    
      return RedirectToAction("Index", new { id = selectedVendor.Id });
    }
  }
}