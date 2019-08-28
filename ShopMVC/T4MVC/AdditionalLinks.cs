namespace Links
{
    public static partial class Bundles
    {
        public static partial class Scripts
        {
            public static string Jquery => "~/bundles/jquery";
            public static string JqueryUi => "~/bundles/jqueryUi";
            public static string JqueryValidation => "~/bundles/jqueryValidation";
            public static string Bootstrap => "~/bundles/bootstrap";
        }

        public static class Styles
        {
            public static string Css => "~/bundles/css";
            public static string UiCss => "~/bundles/uiCss";
        }
    }

    public static class Sections
    {
        public static string AdditionalScripts => "AdditionalScripts";
        public static string AdditionalStyles => "AdditionalStyles";
    }
}