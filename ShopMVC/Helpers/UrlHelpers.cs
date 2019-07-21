using ShopMVC.Code;
using System.IO;
using System.Web.Mvc;

namespace ShopMVC.Helpers
{
    public static class UrlHelpers
    {
        public static string CategoryIcon(this UrlHelper url, string icon)
        {
            return GetIconPath(url, AppConfig.CategoriesIconsFolder, icon);
        }

        public static string CourseIcon(this UrlHelper url, string icon)
        {
            return GetIconPath(url, AppConfig.CoursesIconsFolder, icon);
        }

        public static string GetIconPath(UrlHelper url, string folder, string icon)
        {
            var fullPath = Path.Combine(folder, icon);
            return url.Content(fullPath);
        }
    }
}