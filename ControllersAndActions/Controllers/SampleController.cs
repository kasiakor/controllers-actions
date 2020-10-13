using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ControllersAndActions.Controllers
{
    public class SampleController : Controller
    {
        // GET: Sample
        public ActionResult Index()
        {
            ViewBag.Message = "Hello from  derived controller and index action method";
            return View("MyView");
            //return Content("Hi there!");
        }
        public ActionResult Myip()
        {
            string clientIP = Request.UserHostAddress;
            string serverName = Server.MachineName;
            return Content(serverName);
        }

        public HttpNotFoundResult MyResults()
        {
           
            return HttpNotFound();
        }

        public RedirectResult MyRedirect()
        {
            return Redirect("/Sample/Myip");
        }

        public EmptyResult MyEmpty()
        {
            return new EmptyResult();
        }
    }
}