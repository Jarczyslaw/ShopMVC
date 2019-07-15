namespace Links
{
    public static partial class Bundles
    {
        public static partial class Scripts
        {
            public static readonly string jqueryBundle = "~/bundles/jquery";
            public static readonly string bootstrapBundle = "~/bundles/bootstrap";
        }

        public static class Styles
        {
            public static readonly string cssBundle = "~/bundles/css";
        }
    }

    public static class Sections
    {
        public static readonly string AdditionalScripts = "AdditionalScripts";
        public static readonly string AdditionalStyles = "AdditionalStyles";
    }
}