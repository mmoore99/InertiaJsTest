using System;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using InertiaAdapter;
using InertiaJsTest.Configuration;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace InertiaJsTest.Controllers
{
    public abstract partial class MyBaseController : Controller
    {

        protected MyBaseController()
        {
        }

        public bool IsInertiaRequest { get; private set; } = false;

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            IsInertiaRequest = bool.TryParse(Request.Headers["X-Inertia"], out _);
        }

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            var actionName = this.ControllerContext.RouteData.Values["action"].ToString();
            var controllerName = this.ControllerContext.RouteData.Values["controller"].ToString();
            this.Log().Debug($"Action Completed: Controller={controllerName}, Action={actionName}");
        }

        public IActionResult InertiaResultOrRedirect(string componentName, object props = null)
        {
            // if this is not an inertia request, redirect to do a full page load to initialize Inertia
            props ??= new { };
            return IsInertiaRequest
                ? (IActionResult)Inertia.Render(componentName, props)
                : RedirectToAction("Index", new { redirectComponent = "Home/SampleApi" });
        }
    }
}