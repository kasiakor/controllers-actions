using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ControllersAndActions.Controllers
{
    public class ExampleController : Controller
    {
        // GET: Example
        public ViewResult Index()
        {
            return View("Homepage");
            //return View("~/Index/Other/Index.cshtml");
            //return View("Index", "AlternativeView")
        }
    }
}