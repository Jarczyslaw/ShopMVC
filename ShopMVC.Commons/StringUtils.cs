using System;

namespace ShopMVC.Commons
{
    public static class StringUtils
    {
        public static bool IgnoreCaseContains(string value, string contains)
        {
            if (string.IsNullOrEmpty(value) || string.IsNullOrEmpty(contains))
            {
                return false;
            }

            return value.IndexOf(contains, StringComparison.OrdinalIgnoreCase) >= 0;
        }
    }
}