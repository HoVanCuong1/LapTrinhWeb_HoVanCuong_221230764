using Microsoft.AspNetCore.Mvc;

namespace Day2_Lab2.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult List()
        {
            var products = new List<string> { "LapTop", "Phone", "Table" };
            return View(products);
        }
        public IActionResult Detail(string name)
        {
            ViewBag.Product = name;
            return View();
        }
        public IActionResult Index(string name)
        {
            ViewBag.Product = name;
            return View();
        }
    }
}
