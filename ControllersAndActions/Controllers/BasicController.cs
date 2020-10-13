using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ControllersAndActions.Controllers
{
    public class BasicController : IController
    {
        public void Execute(RequestContext requestContext)
        {
            string controller = (string)requestContext.RouteData.Values["controller"];
            string action = (string)requestContext.RouteData.Values["action"];

            //HttpContext.Current.Request.Url : httpss://localhost:44371/Basic/Index
            // HttpContext.Current.Timestamp : 13/ 10 / 2020 14:34:46
            //HttpContext.Current.Application.Count : 0
            //HttpContext.Current.IsDebuggingEnabled : true
            //HttpContext.Current.User.Identity.IsAuthenticated :  false
            requestContext.HttpContext.Response.Write(string.Format("Controller: {0}, Action: {1}", controller, action));
        }   
    }
}