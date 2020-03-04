using InertiaAdapter;
using InertiaAdapter.Models;
using Microsoft.AspNetCore.Mvc;

namespace InertiaJsTest.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            bool isInertiaRequest = bool.TryParse(Request.Headers["X-Inertia"], out _);
            var model = new Page{Component = "Home/Index", Url = "/home/index"};
            return !isInertiaRequest 
                ? (IActionResult) View(model) 
                : Inertia.Render("Home/Index", new { });
        }

        public IActionResult SampleApi()
        {
            //Inertia.Share = new {MsgShare1 = "this is share 1 message", MsgShare2 = "this is share 2 message"};
            //return Inertia.Render("Home/SampleApi", new {Msg = "this is the message"});
            return Inertia.Render("Home/SampleApi", new {});
        }
    }
}
