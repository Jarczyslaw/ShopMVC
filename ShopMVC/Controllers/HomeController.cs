using ShopMVC.Code;
using ShopMVC.Services;
using ShopMVC.ViewModels;
using System.Linq;
using System.Web.Mvc;

namespace ShopMVC.Controllers
{
    public partial class HomeController : BaseController
    {
        private readonly IAppCache appCache;
        private readonly ICoursesService coursesService;

        public HomeController(ICoursesService coursesService, IAppCache appCache, ILoggerService logger)
            : base(logger)
        {
            this.coursesService = coursesService;
            this.appCache = appCache;
        }

        public virtual ActionResult Index()
        {
            var newCourses = appCache.GetNewCourses(() => coursesService.GetNewCourses()
                .ToList());
            var newBestsellers = appCache.GetBestsellers(() => coursesService.GetBestsellers()
                .ToList());

            return View(MVC.Home.Views.Index, new HomeIndexViewModel()
            {
                NewCourses = newCourses,
                Bestsellers = newBestsellers
            });
        }

        public virtual ActionResult Pages(string page)
        {
            return View(page);
        }
    }
}