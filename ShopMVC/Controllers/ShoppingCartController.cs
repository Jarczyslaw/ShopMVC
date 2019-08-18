using ShopMVC.Commons.Extensions;
using ShopMVC.Services;
using ShopMVC.ViewModels;
using System.Web.Mvc;

namespace ShopMVC.Controllers
{
    public partial class ShoppingCartController : BaseController
    {
        private readonly IShoppingCartService shoppingCartService;
        private readonly ICoursesService coursesService;

        public ShoppingCartController(ICoursesService coursesService, IShoppingCartService shoppingCartService, ILoggerService logger)
            : base(logger)
        {
            this.coursesService = coursesService;
            this.shoppingCartService = shoppingCartService;
        }

        public virtual ActionResult Index()
        {
            return View(MVC.ShoppingCart.Views.Index, new ShoppingCartViewModel
            {
                Positions = shoppingCartService.GetContent()
            });
        }

        public virtual ActionResult AddToCart(int courseId)
        {
            var course = coursesService.GetCourseById(courseId);
            shoppingCartService.Add(course);
            return RedirectToAction(MVC.ShoppingCart.Index());
        }

        [ChildActionOnly]
        public virtual ActionResult GetCartCount()
        {
            return new ContentResult()
            {
                Content = shoppingCartService.GetContentCount().ToString()
            };
        }

        [ChildActionOnly]
        public virtual ActionResult GetCartValue()
        {
            return new ContentResult()
            {
                Content = shoppingCartService.GetContentValue().ToCurrency()
            };
        }

        [ChildActionOnly]
        public virtual ActionResult GetCartLink()
        {
            return PartialView(MVC.Partial.Views._ShoppingCartLink, new ShoppingCartLinkViewModel
            {
                Count = shoppingCartService.GetContentCount(),
                Value = shoppingCartService.GetContentValue()
            });
        }
    }
}