using System.Web.Mvc;

namespace ShopMVC.App_Start
{
    public static class ViewEnginesConfig
    {
        public static void Setup()
        {
            ViewEngines.Engines.Clear();
            ViewEngines.Engines.Add(new RazorViewEngine());
        }
    }
}