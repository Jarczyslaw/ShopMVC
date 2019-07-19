using ShopMVC.DataAccess.Models;
using System;
using System.Collections.Generic;

namespace ShopMVC.Code
{
    public interface IAppCache
    {
        IList<Course> GetNewCourses(Func<IList<Course>> func);
        IList<Course> GetBestsellers(Func<IList<Course>> func);
    }
}