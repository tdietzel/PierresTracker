using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using PierresTracker.Models;

namespace PierresTracker.Controllers
{
  public class VendorController : Controller
  {
    [HttpGet("/vendors")]
    public ActionResult Index()
    {
      List<Vendor> allVendors = Vendor.GetAll();
      return View(allVendors);
    }

    [HttpPost("/vendors")]
    public ActionResult Show(string name, string description)
    {
      Vendor newVendor = new Vendor(name, description);
      return RedirectToAction("Index");
    }

    [HttpGet("/vendors/new")]
    public ActionResult Create() { return View(); }
  }
}