using System.Web.Optimization;

namespace ShopMVC
{
    public static class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle(Links.Bundles.Scripts.JqueryBundle).Include(
                "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle(Links.Bundles.Scripts.JqueryUiBundle).Include(
                "~/Scripts/jquery-ui-{version}.js"));

            bundles.Add(new ScriptBundle(Links.Bundles.Scripts.BootstrapBundle).Include(
                "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle(Links.Bundles.Styles.CssBundle).Include(
                "~/Content/bootstrap.css",
                "~/Content/main.css"));

            bundles.Add(new StyleBundle(Links.Bundles.Styles.UiCssBundle).Include(
                "~/Content/themes/base/core.css",
                "~/Content/themes/base/autocomplete.css",
                "~/Content/themes/base/theme.css",
                "~/Content/themes/base/menu.css"));
        }
    }
}