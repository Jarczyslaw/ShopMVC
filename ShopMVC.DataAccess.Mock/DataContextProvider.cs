using ShopMVC.Commons;
using ShopMVC.DataAccess.Commons;
using ShopMVC.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ShopMVC.DataAccess.Mock
{
    public class DataContextProvider : IDataContextProvider
    {
        private readonly string categoriesKey = "CategoriesKey";
        private readonly string coursesKey = "CoursesKey";

        private readonly ICacheProvider cacheProvider;

        public DataContextProvider(ICacheProvider cacheProvider)
        {
            this.cacheProvider = cacheProvider;
            Load();
        }

        public List<Category> Categories { get; set; }
        public List<Course> Courses { get; set; }

        public void Load()
        {
            Categories = cacheProvider.GetOrSet(categoriesKey, () => SampleDataSource.GetCategories(), TimeSpan.MaxValue).ToList();
            Courses = cacheProvider.GetOrSet(coursesKey, () => SampleDataSource.GetCourses(), TimeSpan.MaxValue).ToList();
        }

        public void Save()
        {
            cacheProvider.Set(categoriesKey, Categories, TimeSpan.MaxValue);
            cacheProvider.Set(coursesKey, Courses, TimeSpan.MaxValue);
        }
    }
}