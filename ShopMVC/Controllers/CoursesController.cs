using ShopMVC.DataAccess.Models;
using ShopMVC.Services;
using ShopMVC.ViewModels;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace ShopMVC.Controllers
{
    public partial class CoursesController : BaseController
    {
        private readonly ICoursesService coursesService;
        // TODO - remove it from here
        private readonly ICategoriesService categoriesService;

        public CoursesController(ICoursesService coursesService, ICategoriesService categoriesService, ILoggerService logger)
            : base(logger)
        {
            this.coursesService = coursesService;
            this.categoriesService = categoriesService;
        }

        public virtual ActionResult List(int categoryId, string searchQuery = null)
        {
            if (Request.IsAjaxRequest())
            {
                return PartialView(MVC.Partial.Views._CoursesList, coursesService.GetCoursesByTerm(searchQuery, 5));
            }

            return Subview(MVC.Courses.Views.List, new CoursesListViewModel()
            {
                Category = categoriesService.GetCategoryById(categoryId),
                Courses = coursesService.GetCoursesInCategory(categoryId)
            });
        }

        public virtual ActionResult Details(int courseId)
        {
            var course = coursesService.GetCourseById(courseId);
            return Subview(MVC.Courses.Views.Details, new CourseDetailsViewModel()
            {
                Course = course,
                Category = categoriesService.GetCategoryById(course.CategoryId)
            });
        }

        public virtual ActionResult CoursesPrompt(string term)
        {
            var courses = coursesService.GetCoursesByTerm(term, 5)
                .Select(c => new { label = c.Title });
            return Json(courses, JsonRequestBehavior.AllowGet);
        }
    }
}