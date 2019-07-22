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
            var courses = coursesService.GetCoursesInCategory(categoryId);

            return Subview(MVC.Courses.Views.List, new CoursesListViewModel()
            {
                Category = category,
                Courses = courses
            });
        }

        public virtual ActionResult Details(int courseId)
        {
            var course = coursesService.GetCourseById(courseId);
            var category = categoriesService.GetCategoryById(course.CategoryId);

            return Subview(MVC.Courses.Views.Details, new CourseDetailsViewModel()
            {
                Course = course,
                Category = category
            });
        }
    }
}