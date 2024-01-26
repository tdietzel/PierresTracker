using Microsoft.AspNetCore.Mvc;
using PierresTracker.Models;

namespace PierresTracker.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public string Index() { return "Hello Pierre!"; }
  }
}