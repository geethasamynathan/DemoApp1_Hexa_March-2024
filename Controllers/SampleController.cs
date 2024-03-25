using Microsoft.AspNetCore.Mvc;

namespace DemoApp1.Controllers
{
    public class SampleController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Name"] = "Geetha";
            ViewBag.Designation = "Consultant";
            return View();
        }
    }
}
