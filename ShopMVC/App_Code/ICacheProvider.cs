using System;

namespace ShopMVC.App_Code
{
    public interface ICacheProvider
    {
        object Get(string key);

        T Get<T>(string key);

        T GetOrSet<T>(string key, Func<T> func, int duration);

        void Set(string key, object value, int duration);

        bool IsSet(string key);

        void Invalidate(string key);
    }
}