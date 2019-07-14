using ShopMVC.Code;
using ShopMVC.Services;
using System;
using System.Web.Mvc;

namespace ShopMVC.Controllers
{
    public partial class HomeController : BaseController
    {
        public HomeController(IAppConfig appConfiguration, ILoggerService logger)
            : base(appConfiguration, logger)
        {
        }

        public virtual ActionResult Index()
        {
            return View();
        }

        public virtual ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            ViewBag.Test = appConfiguration.Test;
            return View();
        }

        public virtual ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            throw new Exception("Custom exception");
            return View();
        }
    }
}