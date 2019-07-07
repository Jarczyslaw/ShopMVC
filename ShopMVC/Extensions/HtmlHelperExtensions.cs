using ShopMVC.Helpers;
using System;
using System.Web.Mvc;

namespace ShopMVC.Extensions
{
    public static class HtmlHelperExtensions
    {
        public static IDisposable Paragraph(this HtmlHelper helper)
        {
            var writer = helper.ViewContext.Writer;
            void begin() => writer.Write("<p>");
            void end() => writer.Write("</p>");
            return new DisposableHelper(begin, end);
        }
    }
}