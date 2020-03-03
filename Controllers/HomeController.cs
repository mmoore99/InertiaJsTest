using InertiaAdapter.Models;
using Microsoft.AspNetCore.Mvc;

namespace InertiaJsTest.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var model = new Page{Component = "home/index/App", Url = "/home/index"};
            return View(model);
        }

        public IActionResult SampleApi()
        {
            return View();
        }
    }
}
