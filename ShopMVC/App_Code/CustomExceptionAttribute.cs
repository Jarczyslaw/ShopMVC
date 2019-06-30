using System.Diagnostics;
using System.Web.Mvc;

namespace ShopMVC.App_Code
{
    public class CustomExceptionAttribute : HandleErrorAttribute
    {
        public override void OnException(ExceptionContext filterContext)
        {
            var ex = filterContext.Exception;
            Debug.WriteLine("OnException: " + ex.Message);

            var controller = (string)filterContext.RouteData.Values["controller"];
            var action = (string)filterContext.RouteData.Values["action"];
            var model = new HandleErrorInfo(ex, controller, action);

            filterContext.Result = new PartialViewResult()
            {
                ViewName = MVC.Shared.Views._Error,
                ViewData = new ViewDataDictionary<HandleErrorInfo>(model)
            };

            filterContext.ExceptionHandled = true;
        }
    }
}