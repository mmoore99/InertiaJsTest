using InertiaAdapter;
using InertiaAdapter.Models;
using Microsoft.AspNetCore.Mvc;

namespace InertiaJsTest.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //var model = new Page{Component = "home/index/Index", Url = "/home/index"};
            var model = new Page{Component = "Home/Index", Url = "/home/index"};
            return View(model);
        }

        public IActionResult SampleApi()
        {
            return Inertia.Render("Home/SampleApi", new {});
        }
    }
}
