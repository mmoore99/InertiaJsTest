using Microsoft.AspNetCore.Mvc;

namespace InertiaJsTest.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SampleApi()
        {
            return View();
        }
    }
}
