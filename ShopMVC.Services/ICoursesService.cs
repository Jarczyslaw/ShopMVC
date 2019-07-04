using ShopMVC.DataAccess.Models;
using System.Collections.Generic;

namespace ShopMVC.Services
{
    public interface ICoursesService
    {
        IEnumerable<Course> GetNewCourses(int count = 3);

        IEnumerable<Course> GetBestsellers(int count = 3);

        Course GetCourseById(int id);

        IEnumerable<Course> GetCoursesInCategory(int categoryId);

        IEnumerable<Course> GetAll();
    }
}