using ShopMVC.App_Code;
using System;
using System.Web.Mvc;

namespace ShopMVC.Controllers
{
    public partial class HomeController : BaseController
    {
        public HomeController(IAppConfiguration appConfiguration) : base(appConfiguration)
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