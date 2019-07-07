using ShopMVC.DataAccess.Commons;
using System.Data.Entity.Migrations;
using System.Linq;

namespace ShopMVC.DataAccess
{
    public static class DataSeeder
    {
        public static void SeedDatabase(DataContext context)
        {
            var categories = SampleDataSource.GetCategories();
            context.Categories.AddOrUpdate(categories.ToArray());

            var courses = SampleDataSource.GetCourses();
            context.Courses.AddOrUpdate(courses.ToArray());

            context.SaveChanges();
        }
    }
}