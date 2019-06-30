using System.Web.Mvc;
using ShopMVC.App_Code;

namespace ShopMVC
{
    public static class FilterConfig
    {
        public static void RegisterFilters(GlobalFilterCollection filters, params FilterAttribute[] filtersToAdd)
        {
            foreach (var filter in filtersToAdd)
            {
                filters.Add(filter);
            }
        }

        public static void RegisterGlobalErrorHandling(GlobalFilterCollection filters)
        {
            RegisterFilters(filters, new CustomExceptionAttribute());
        }

        public static void RegisterFilters(GlobalFilterCollection filters)
        {
            RegisterGlobalErrorHandling(filters);
        }
    }
}