using System;
using System.Collections.Generic;
using System.Linq;

namespace ShopMVC.Commons
{
    public static class IEnumerableExtensions
    {
        public static int SafeMax<T>(this IEnumerable<T> collection, Func<T, int> selector, int defaultValue = 0)
        {
            if (!collection.Any())
            {
                return defaultValue;
            }

            return collection.Max(selector);
        }
    }
}