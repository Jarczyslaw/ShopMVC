using ShopMVC.DataAccess.Models;
using System;
using System.Collections.Generic;

namespace ShopMVC.DataAccess.Commons
{
    public static class SampleDataSource
    {
        public static IEnumerable<Course> GetCourses()
        {
            return new List<Course>()
            {
                new Course() { AddedDate = DateTime.Now.AddDays(-1), Author = "Philip", CategoryId = 1, Bestseller = true, CourseId = 1, ImageFilePath = "", Price = 29m,
                    Title = "C# Level 1", Hidden = false, Description = "Level 1 of C#: classes and objects", ShortDescription = "C# Level 1" },
                new Course() { AddedDate = DateTime.Now.AddDays(-2), Author = "Philip", CategoryId = 1, Bestseller = false, CourseId = 2, ImageFilePath = "", Price = 49m,
                    Title = "C# Level 2", Hidden = false, Description = "Level 2 of C#: interfaces", ShortDescription = "C# Level 2" },
                new Course() { AddedDate = DateTime.Now.AddDays(-8), Author = "Philip", CategoryId = 1, Bestseller = false, CourseId = 3, ImageFilePath = "", Price = 69m,
                    Title = "C# Level 3", Hidden = false, Description = "Level 3 of C#: delegates and events", ShortDescription = "C# Level 3" },
                new Course() { AddedDate = DateTime.Now.AddDays(-4), Author = "Alex", CategoryId = 2, Bestseller = true, CourseId = 4, ImageFilePath = "", Price = 199m,
                    Title = "ASP.NET MVC Professional", Hidden = false, Description = "ASP.NET MVC for professionals. All you need to become a professional ASP.NET MVC developer", ShortDescription = "ASP.NET MVC for professionals" },
                new Course() { AddedDate = DateTime.Now.AddDays(-3), Author = "David", CategoryId = 2, Bestseller = false, CourseId = 5, ImageFilePath = "", Price = 99m,
                    Title = "ASP.NET MVC Entry level", Hidden = false, Description = "Basics of ASP.NET MVC. Learn how to create simple applications in ASP.MVC", ShortDescription = "Basics of ASP.NET MVC" },
                new Course() { AddedDate = DateTime.Now.AddDays(-5), Author = "Mark", CategoryId = 4, Bestseller = true, CourseId = 6, ImageFilePath = "", Price = 50m,
                    Title = "jQuery Tutorials", Hidden = false, Description = "Tutorials for jQuery. Basic and advanced techniques to make your webpage alive", ShortDescription = "Tutorials for jQuery" },
                new Course() { AddedDate = DateTime.Now, Author = "Robert", CategoryId = 4, Bestseller = true, CourseId = 7, ImageFilePath = "", Price = 299m,
                    Title = "Angular Development", Hidden = false, Description = "Frontend with Angular. Use this popular frontend framework to create robust single page applications", ShortDescription = "Frontend with Angular" }
            };
        }

        public static IEnumerable<Category> GetCategories()
        {
            return new List<Category>()
            {
                new Category() { CategoryId = 1, Title = "C#", ImageFilePath = "csharp.png", Description = "C# courses" },
                new Category() { CategoryId = 2, Title = "ASP.NET MVC", ImageFilePath = "aspmvc.png", Description = "ASP.NET MVC courses" },
                new Category() { CategoryId = 3, Title = "MS SQL", ImageFilePath = "mssql.png", Description = "MS SQL courses" },
                new Category() { CategoryId = 4, Title = "JavaScript", ImageFilePath = "js.png", Description = "JavaScript courses" }
            };
        }
    }
}