using System.Configuration;
using System.Runtime.CompilerServices;

namespace ShopMVC.Code
{
    public static class AppConfig
    {
        public static string GetConfigValue([CallerMemberName]string key = null)
        {
            return ConfigurationManager.AppSettings[key];
        }

        public static string CategoriesIconsFolder => GetConfigValue();
        public static string CoursesIconsFolder => GetConfigValue();
    }
}