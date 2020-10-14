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

        public RedirectToRouteResult Redirect3()
        {
            //in the same controller
            //temporary redirect
            return RedirectToAction("Index2");
            //return RedirectToActionPermanent("Index2");
        }

        public RedirectToRouteResult Redirect4()
        {
            //another controller
            //temporary redirect
            return RedirectToAction("Index", "Sample");
            //return RedirectToActionPermanent("Index", "Sample");
        }

        public RedirectToRouteResult Redirect5()
        {
            //preserve data while redirecting using TempData
            TempData["Message"] = "Hello";
            TempData["Date"] = DateTime.Now;
            return RedirectToAction("Index");
            //return RedirectToActionPermanent("Index", "Sample");
        }

        public HttpStatusCodeResult StatusCode()
        {
       //initiate the class directly, no helper method
            return new HttpStatusCodeResult(404, "Url cannot be serviced");
            //return RedirectToActionPermanent("Index", "Sample");
        }

        public HttpStatusCodeResult StatusCode2()
        {
            //generates 404 result
            return HttpNotFound();
        }

        public HttpStatusCodeResult StatusCode3()
        {
            //generates 401 result
            return new HttpUnauthorizedResult();
        }
    }
}