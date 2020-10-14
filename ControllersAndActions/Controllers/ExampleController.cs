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
            DateTime date = DateTime.Now;
            return View(date);
            //return View("~/Index/Other/Index.cshtml");
            //return View("Index", "AlternativeView")
        }

        public ViewResult Index2()
        {
            //dynamic object
            ViewBag.Date = DateTime.Now;
            return View();  
        }

        public RedirectResult Redirect()
        {
            //literal url
            return Redirect("/Example/Index2");
        }

        public RedirectToRouteResult Redirect2()
        {
            //routing system generates url
            //temporary redirect
            return RedirectToRoute(new { 
                controller = "Example",
                action ="Index",
                ID = "MyID"
            //return RedirectPermanent("/Example/Index");
            });
        }
    }
}