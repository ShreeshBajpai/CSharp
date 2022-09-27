using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class ServiceController : Controller
    {
        public IActionResult Home()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
    }
}
