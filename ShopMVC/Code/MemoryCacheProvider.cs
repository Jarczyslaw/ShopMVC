using ShopMVC.Commons;
using System;
using System.Runtime.Caching;

namespace ShopMVC.Code
{
    public class MemoryCacheProvider : IMemoryCacheProvider
    {
        public object Get(string key)
        {
            return MemoryCache.Default.Get(key);
        }

        public T Get<T>(string key)
        {
            return (T)Get(key);
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

        public bool IsSet(string key)
        {
            return MemoryCache.Default.Contains(key);
        }

        public void Remove(string key)
        {
            MemoryCache.Default.Remove(key);
        }

        public void Set(string key, object value, TimeSpan duration)
        {
            MemoryCache.Default.Set(key, value, DateTime.Now);
        }
    }
}