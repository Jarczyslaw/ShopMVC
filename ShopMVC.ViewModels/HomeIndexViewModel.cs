using ShopMVC.DataAccess.Models;
using System.Collections.Generic;

namespace ShopMVC.ViewModels
{
    public class HomeIndexViewModel
    {
        public IEnumerable<Course> NewCourses { get; set; }
        public IEnumerable<Course> Bestsellers { get; set; }
    }
}