﻿using System;

namespace ShopMVC.Commons.Abstraction
{
    public interface ICacheProvider
    {
        object Get(string key);

        T Get<T>(string key);

        T GetOrSet<T>(string key, Func<T> func, TimeSpan duration);

        void Set(string key, object value, TimeSpan duration);

        bool IsSet(string key);

        void Remove(string key);

        void Clear();
    }
}