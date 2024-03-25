using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace DemoApp1.Controllers
{
    public class DemoController : Controller
    {
      
        public IActionResult Method1()
        {
            TempData["name"] = "Geetha";
            TempData["location"] = "CBE";
            return RedirectToAction("Method2");
        }
        public IActionResult Method2()
        {
            TempData.Keep();
            return View();
        }
        public IActionResult Method3()
        {
         //if(TempData.ContainsKey("name"))  
                ViewBag.Name = TempData["name"];

            return View();
        }
    }
}
