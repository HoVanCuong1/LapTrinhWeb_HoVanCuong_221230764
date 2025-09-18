using Microsoft.AspNetCore.Mvc;

namespace Day04_Layout.Areas.Admins.Controllers
{
    [Area("Admins")]
    public class UsersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
