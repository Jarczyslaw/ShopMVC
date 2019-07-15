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

        public virtual ActionResult Pages(string page)
        {
            return View(page);
        }
    }
}