using Day2_Lab2.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Day2_Lab2.Controllers
{
    public class HvcHomeController : Controller
    {
        private readonly ILogger<HvcHomeController> _logger;

        public HvcHomeController(ILogger<HvcHomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult HvcIndex()
        {
            return View();
        }

        public IActionResult HvcAbout()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
