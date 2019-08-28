using System.Web.Optimization;

namespace ShopMVC
{
    public static class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle(Links.Bundles.Scripts.Jquery).Include(
                "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle(Links.Bundles.Scripts.JqueryUi).Include(
                "~/Scripts/jquery-ui-{version}.js"));

            bundles.Add(new ScriptBundle(Links.Bundles.Scripts.JqueryValidation).Include(
                "~/Scripts/jquery.validate.js",
                "~/Scripts/jquery.validate.unobtrusive.js"));

            bundles.Add(new ScriptBundle(Links.Bundles.Scripts.Bootstrap).Include(
                "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle(Links.Bundles.Styles.Css).Include(
                "~/Content/bootstrap.css",
                "~/Content/main.css"));

            bundles.Add(new StyleBundle(Links.Bundles.Styles.UiCss).Include(
                "~/Content/themes/base/core.css",
                "~/Content/themes/base/autocomplete.css",
                "~/Content/themes/base/theme.css",
                "~/Content/themes/base/menu.css"));
        }
    }
}