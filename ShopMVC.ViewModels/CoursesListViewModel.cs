using ShopMVC.DataAccess.Models;
using System.Collections.Generic;

namespace ShopMVC.ViewModels
{
    public class CoursesListViewModel
    {
        public Category Category { get; set; }
        public IEnumerable<Course> Courses { get; set; }
    }
}