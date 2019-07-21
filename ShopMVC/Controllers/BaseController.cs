using ShopMVC.Services;
using ShopMVC.ViewModels;
using System.Web.Mvc;

namespace ShopMVC.Controllers
{
    public partial class BaseController : Controller
    {
        protected readonly ILoggerService logger;

        public BaseController()
        {
        }

        public BaseController(ILoggerService logger)
        {
            this.logger = logger;
        }

        public virtual ActionResult Subview(string targetView, object viewModel)
        {
            var subviewViewModel = new SubviewViewModel()
            {
                TargetView = targetView,
                TargetViewModel = viewModel
            };
            return View(MVC.Shared.Views._SubView, subviewViewModel);
        }

        protected override void OnException(ExceptionContext filterContext)
        {
            var exception = filterContext.Exception;
            logger.Fatal(exception);

            var controller = (string)filterContext.RouteData.Values["controller"];
            var action = (string)filterContext.RouteData.Values["action"];
            filterContext.Result = new PartialViewResult()
            {
                ViewName = MVC.Shared.Views._Error,
                ViewData = new ViewDataDictionary<HandleErrorInfo>(new HandleErrorInfo(exception, controller, action))
            };

            filterContext.ExceptionHandled = true;
            base.OnException(filterContext);
        }
    }
}