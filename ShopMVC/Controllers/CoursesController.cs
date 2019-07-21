using ShopMVC.Services;
using ShopMVC.ViewModels;
using System.Web.Mvc;

namespace ShopMVC.Controllers
{
    public partial class CoursesController : BaseController
    {
        private readonly ICoursesService coursesService;
        private readonly ICategoriesService categoriesService;

        public CoursesController(ICoursesService coursesService, ICategoriesService categoriesService, ILoggerService logger)
            : base(logger)
        {
            this.coursesService = coursesService;
            this.categoriesService = categoriesService;
        }

        public virtual ActionResult List(int categoryId)
        {
            var category = categoriesService.GetCategoryById(categoryId);
            var cs = coursesService.GetCoursesInCategory(categoryId);
            var vm = new CoursesListViewModel()
            {
                Category = category,
                Courses = cs
            };
            return Subview(MVC.Courses.Views.List, vm);
        }

        public virtual ActionResult Details(int courseId)
        {
            var course = coursesService.GetCourseById(courseId);
            var category = categoriesService.GetCategoryById(course.CategoryId);

            var vm = new CourseDetailsViewModel()
            {
                Course = course,
                Category = category
            };
            return Subview(MVC.Courses.Views.Details, vm);
        }
    }
}