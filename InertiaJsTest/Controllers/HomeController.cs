using InertiaAdapter;
using InertiaAdapter.Models;
using InertiaJsTest.Helpers.Extensions;
using Microsoft.AspNetCore.Mvc;

namespace InertiaJsTest.Controllers
{
    public class HomeController : MyBaseController
    {
        public IActionResult Index(string redirectComponent)
        {
            var component = redirectComponent.IsEmpty()
                ? "Home/Index"
                : redirectComponent;

            var model = new Page {Component = component, Url = component};
            
            return !IsInertiaRequest
                ? (IActionResult) View(model)
                : Inertia.Render("Home/Index", new { });
        }

        public IActionResult SampleApi()
        {
            return InertiaResultOrRedirect("Home/SampleApi");
        }

        public IActionResult About()
        {
            Inertia.Share = new {MsgShare1 = "this is share 1 message", MsgShare2 = "this is share 2 message"};
            return InertiaResultOrRedirect("Home/About", new { Msg = "this is a message from a prop" });
        }
    }
}
