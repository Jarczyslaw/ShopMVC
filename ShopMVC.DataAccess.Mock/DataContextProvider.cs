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

        private readonly IMemoryCacheProvider memoryCacheProvider;

        public DataContextProvider(IMemoryCacheProvider memoryCacheProvider)
        {
            this.memoryCacheProvider = memoryCacheProvider;
            Load();
        }

        public List<Category> Categories { get; set; }
        public List<Course> Courses { get; set; }

        public void Load()
        {
            var expiration = TimeSpan.FromDays(1);
            Categories = memoryCacheProvider.GetOrSet(categoriesKey, SampleDataSource.GetCategories, expiration).ToList();
            Courses = memoryCacheProvider.GetOrSet(coursesKey, SampleDataSource.GetCourses, expiration).ToList();
        }

        public void Save()
        {
            memoryCacheProvider.Set(categoriesKey, Categories, TimeSpan.MaxValue);
            memoryCacheProvider.Set(coursesKey, Courses, TimeSpan.MaxValue);
        }
    }
}