using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCEgitim.Filters
{
    public class UserControl:ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var Usersession = filterContext.HttpContext.Session["deger"];
            var usecCookie = filterContext.HttpContext.Request.Cookies["userguid"];
            if( Usersession==null )
            {
                filterContext.Result = new RedirectResult("/MVC11Session?msg=AcessDenied");
            }
            base.OnActionExecuting(filterContext);
        }
    }
}