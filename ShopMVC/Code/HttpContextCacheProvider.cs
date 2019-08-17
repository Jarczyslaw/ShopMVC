using ShopMVC.Commons;
using ShopMVC.Commons.Abstraction;
using System;
using System.Web;
using System.Web.Caching;

namespace ShopMVC.Code
{
    public class HttpContextCacheProvider : IHttpContextCacheProvider
    {
        public Cache Cache => HttpContext.Current.Cache;

        public object Get(string key)
        {
            return Cache.Get(key);
        }

        public T GetOrSet<T>(string key, Func<T> func, TimeSpan duration)
        {
            if (IsSet(key))
            {
                return Get<T>(key);
            }
            else
            {
                T newValue = func();
                Set(key, newValue, duration);
                return newValue;
            }
        }

        public T Get<T>(string key)
        {
            return (T)Get(key);
        }

        public bool IsSet(string key)
        {
            return Cache.Get(key) != null;
        }

        public void Set(string key, object value, TimeSpan duration)
        {
            Cache.Insert(key, value, null, DateTime.Now + duration, Cache.NoSlidingExpiration);
        }

        public void Remove(string key)
        {
            Cache.Remove(key);
        }
    }
}