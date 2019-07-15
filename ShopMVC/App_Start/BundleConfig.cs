using System.Web.Optimization;

namespace ShopMVC
{
    public static class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle(Links.Bundles.Scripts.jqueryBundle).Include(
                "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle(Links.Bundles.Scripts.bootstrapBundle).Include(
                "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle(Links.Bundles.Styles.cssBundle).Include(
                "~/Content/bootstrap.css",
                "~/Content/main.css"));
        }
    }
}