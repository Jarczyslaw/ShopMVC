using ShopMVC.Services;
using System.Linq;
using System.Web.Mvc;

namespace ShopMVC.Controllers
{
    public partial class CategoriesController : BaseController
    {
        private readonly ICategoriesService categoriesService;

        public CategoriesController(ICategoriesService categoriesService, ILoggerService logger)
            : base(logger)
        {
            this.categoriesService = categoriesService;
        }

        [ChildActionOnly]
        [OutputCache(Duration = 60 * 60 * 24)]
        public virtual ActionResult List()
        {
            var categories = categoriesService.GetCategoriesList()
                .ToList();
            return PartialView(MVC.Partial.Views._CategoriesList, categories);
        }
    }
}