using ShopMVC.Commons;
using ShopMVC.DataAccess.Models;
using System;
using System.Collections.Generic;

namespace ShopMVC.Code
{
    public class AppCache : IAppCache
    {
        private readonly IMemoryCacheProvider memoryCacheProvider;
        private readonly IHttpContextCacheProvider httpContextCacheProvider;

        private readonly TimeSpan defaultCacheDuration = TimeSpan.FromMinutes(1);

        private readonly string newCoursesKey = "NewCoursesKey";
        private readonly string bestsellerCoursesKey = "BestsellerCoursesKey";

        public AppCache(IMemoryCacheProvider memoryCacheProvider, IHttpContextCacheProvider httpContextCacheProvider)
        {
            this.memoryCacheProvider = memoryCacheProvider;
            this.httpContextCacheProvider = httpContextCacheProvider;
        }

        public IList<Course> GetNewCourses(Func<IList<Course>> func)
        {
            return httpContextCacheProvider.GetOrSet(newCoursesKey, func, defaultCacheDuration);
        }

        public IList<Course> GetBestsellers(Func<IList<Course>> func)
        {
            return httpContextCacheProvider.GetOrSet(bestsellerCoursesKey, func, defaultCacheDuration);
        }
    }
}