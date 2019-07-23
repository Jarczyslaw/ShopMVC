namespace Links
{
    public static partial class Bundles
    {
        public static partial class Scripts
        {
            public static string JqueryBundle => "~/bundles/jquery";
            public static string JqueryUiBundle => "~/bundles/jqueryUi";
            public static string BootstrapBundle => "~/bundles/bootstrap";
        }

        public static class Styles
        {
            public static string CssBundle => "~/bundles/css";
            public static string UiCssBundle => "~/bundles/uiCss";
        }
    }

    public static class Sections
    {
        public static string AdditionalScripts => "AdditionalScripts";
        public static string AdditionalStyles => "AdditionalStyles";
    }
}