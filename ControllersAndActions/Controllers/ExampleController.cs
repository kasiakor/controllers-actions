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
    }
}