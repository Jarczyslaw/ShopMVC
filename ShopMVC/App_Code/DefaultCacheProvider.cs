using System;
using System.Web;
using System.Web.Caching;

namespace ShopMVC.App_Code
{
    public class DefaultCacheProvider : ICacheProvider
    {
        public Cache Cache
        {
            get { return HttpContext.Current.Cache; }
        }

        public object Get(string key)
        {
            return Cache.Get(key);
        }

        public T GetOrSet<T>(string key, Func<T> func, int duration)
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

        public void Set(string key, object value, int duration)
        {
            var expirationTime = DateTime.Now.AddSeconds(duration);
            Cache.Insert(key, value, null, expirationTime, Cache.NoSlidingExpiration);
        }

        public void Invalidate(string key)
        {
            Cache.Remove(key);
        }
    }
}