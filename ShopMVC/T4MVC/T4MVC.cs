﻿// <auto-generated />
// This file was generated by a T4 template.
// Don't change it directly as your change would get overwritten.  Instead, make changes
// to the .tt file (i.e. the T4 template) and save it to regenerate this file.

// Make sure the compiler doesn't complain about missing Xml comments and CLS compliance
// 0108: suppress "Foo hides inherited member Foo. Use the new keyword if hiding was intended." when a controller and its abstract parent are both processed
// 0114: suppress "Foo.BarController.Baz()' hides inherited member 'Qux.BarController.Baz()'. To make the current member override that implementation, add the override keyword. Otherwise add the new keyword." when an action (with an argument) overrides an action in a parent controller
#pragma warning disable 1591, 3008, 3009, 0108, 0114
#region T4MVC

using System;
using System.Diagnostics;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Web;
using System.Web.Hosting;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using System.Web.Mvc.Html;
using System.Web.Routing;
using T4MVC;

[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
public static partial class MVC
{
    public static ShopMVC.Controllers.BaseController Base = new ShopMVC.Controllers.T4MVC_BaseController();
    public static ShopMVC.Controllers.HomeController Home = new ShopMVC.Controllers.T4MVC_HomeController();
    public static T4MVC.SharedController Shared = new T4MVC.SharedController();
}

namespace T4MVC
{
}

#pragma warning disable 0436
namespace T4MVC
{
    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public class Dummy
    {
        private Dummy() { }
        public static Dummy Instance = new Dummy();
    }
}
#pragma warning restore 0436

[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
internal partial class T4MVC_System_Web_Mvc_ActionResult : System.Web.Mvc.ActionResult, IT4MVCActionResult
{
    public T4MVC_System_Web_Mvc_ActionResult(string area, string controller, string action, string protocol = null): base()
    {
        this.InitMVCT4Result(area, controller, action, protocol);
    }
     
    public override void ExecuteResult(System.Web.Mvc.ControllerContext context) { }
    
    public string Controller { get; set; }
    public string Action { get; set; }
    public string Protocol { get; set; }
    public RouteValueDictionary RouteValueDictionary { get; set; }
}



namespace Links
{
    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public static class Scripts {
        public const string UrlPath = "~/Scripts";
        public static string Url() { return T4MVCHelpers.ProcessVirtualPath(UrlPath); }
        public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(UrlPath + "/" + fileName); }
        public static readonly string bootstrap_bundle_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/bootstrap.bundle.min.js") ? Url("bootstrap.bundle.min.js") : Url("bootstrap.bundle.js");
        public static readonly string bootstrap_bundle_js_map = Url("bootstrap.bundle.js.map");
        public static readonly string bootstrap_bundle_min_js = Url("bootstrap.bundle.min.js");
        public static readonly string bootstrap_bundle_min_js_map = Url("bootstrap.bundle.min.js.map");
        public static readonly string bootstrap_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/bootstrap.min.js") ? Url("bootstrap.min.js") : Url("bootstrap.js");
        public static readonly string bootstrap_js_map = Url("bootstrap.js.map");
        public static readonly string bootstrap_min_js = Url("bootstrap.min.js");
        public static readonly string bootstrap_min_js_map = Url("bootstrap.min.js.map");
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public static class esm {
            public const string UrlPath = "~/Scripts/esm";
            public static string Url() { return T4MVCHelpers.ProcessVirtualPath(UrlPath); }
            public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(UrlPath + "/" + fileName); }
            public static readonly string popper_utils_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/popper-utils.min.js") ? Url("popper-utils.min.js") : Url("popper-utils.js");
            public static readonly string popper_utils_js_map = Url("popper-utils.js.map");
            public static readonly string popper_utils_min_js = Url("popper-utils.min.js");
            public static readonly string popper_utils_min_js_map = Url("popper-utils.min.js.map");
            public static readonly string popper_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/popper.min.js") ? Url("popper.min.js") : Url("popper.js");
            public static readonly string popper_js_map = Url("popper.js.map");
            public static readonly string popper_min_js = Url("popper.min.js");
            public static readonly string popper_min_js_map = Url("popper.min.js.map");
        }
    
        public static readonly string index_d_ts = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/index.d.min.js") ? Url("index.d.min.js") : Url("index.d.js");
        public static readonly string jquery_3_4_1_intellisense_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/jquery-3.4.1.intellisense.min.js") ? Url("jquery-3.4.1.intellisense.min.js") : Url("jquery-3.4.1.intellisense.js");
        public static readonly string jquery_3_4_1_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/jquery-3.4.1.min.js") ? Url("jquery-3.4.1.min.js") : Url("jquery-3.4.1.js");
        public static readonly string jquery_3_4_1_min_js = Url("jquery-3.4.1.min.js");
        public static readonly string jquery_3_4_1_min_map = Url("jquery-3.4.1.min.map");
        public static readonly string jquery_3_4_1_slim_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/jquery-3.4.1.slim.min.js") ? Url("jquery-3.4.1.slim.min.js") : Url("jquery-3.4.1.slim.js");
        public static readonly string jquery_3_4_1_slim_min_js = Url("jquery-3.4.1.slim.min.js");
        public static readonly string jquery_3_4_1_slim_min_map = Url("jquery-3.4.1.slim.min.map");
        public static readonly string jquery_validate_vsdoc_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/jquery.validate-vsdoc.min.js") ? Url("jquery.validate-vsdoc.min.js") : Url("jquery.validate-vsdoc.js");
        public static readonly string jquery_validate_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/jquery.validate.min.js") ? Url("jquery.validate.min.js") : Url("jquery.validate.js");
        public static readonly string jquery_validate_min_js = Url("jquery.validate.min.js");
        public static readonly string jquery_validate_unobtrusive_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/jquery.validate.unobtrusive.min.js") ? Url("jquery.validate.unobtrusive.min.js") : Url("jquery.validate.unobtrusive.js");
        public static readonly string jquery_validate_unobtrusive_min_js = Url("jquery.validate.unobtrusive.min.js");
        public static readonly string modernizr_2_8_3_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/modernizr-2.8.3.min.js") ? Url("modernizr-2.8.3.min.js") : Url("modernizr-2.8.3.js");
        public static readonly string popper_utils_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/popper-utils.min.js") ? Url("popper-utils.min.js") : Url("popper-utils.js");
        public static readonly string popper_utils_js_map = Url("popper-utils.js.map");
        public static readonly string popper_utils_min_js = Url("popper-utils.min.js");
        public static readonly string popper_utils_min_js_map = Url("popper-utils.min.js.map");
        public static readonly string popper_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/popper.min.js") ? Url("popper.min.js") : Url("popper.js");
        public static readonly string popper_js_map = Url("popper.js.map");
        public static readonly string popper_min_js = Url("popper.min.js");
        public static readonly string popper_min_js_map = Url("popper.min.js.map");
        public static readonly string README_md = Url("README.md");
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public static class umd {
            public const string UrlPath = "~/Scripts/umd";
            public static string Url() { return T4MVCHelpers.ProcessVirtualPath(UrlPath); }
            public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(UrlPath + "/" + fileName); }
            public static readonly string popper_utils_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/popper-utils.min.js") ? Url("popper-utils.min.js") : Url("popper-utils.js");
            public static readonly string popper_utils_js_map = Url("popper-utils.js.map");
            public static readonly string popper_utils_min_js = Url("popper-utils.min.js");
            public static readonly string popper_utils_min_js_map = Url("popper-utils.min.js.map");
            public static readonly string popper_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/popper.min.js") ? Url("popper.min.js") : Url("popper.js");
            public static readonly string popper_js_map = Url("popper.js.map");
            public static readonly string popper_min_js = Url("popper.min.js");
            public static readonly string popper_min_js_map = Url("popper.min.js.map");
        }
    
    }

    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public static class Content {
        public const string UrlPath = "~/Content";
        public static string Url() { return T4MVCHelpers.ProcessVirtualPath(UrlPath); }
        public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(UrlPath + "/" + fileName); }
        public static readonly string bootstrap_grid_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/bootstrap-grid.min.css") ? Url("bootstrap-grid.min.css") : Url("bootstrap-grid.css");
        public static readonly string bootstrap_grid_css_map = Url("bootstrap-grid.css.map");
        public static readonly string bootstrap_grid_min_css = Url("bootstrap-grid.min.css");
        public static readonly string bootstrap_grid_min_css_map = Url("bootstrap-grid.min.css.map");
        public static readonly string bootstrap_reboot_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/bootstrap-reboot.min.css") ? Url("bootstrap-reboot.min.css") : Url("bootstrap-reboot.css");
        public static readonly string bootstrap_reboot_css_map = Url("bootstrap-reboot.css.map");
        public static readonly string bootstrap_reboot_min_css = Url("bootstrap-reboot.min.css");
        public static readonly string bootstrap_reboot_min_css_map = Url("bootstrap-reboot.min.css.map");
        public static readonly string bootstrap_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/bootstrap.min.css") ? Url("bootstrap.min.css") : Url("bootstrap.css");
        public static readonly string bootstrap_css_map = Url("bootstrap.css.map");
        public static readonly string bootstrap_min_css = Url("bootstrap.min.css");
        public static readonly string bootstrap_min_css_map = Url("bootstrap.min.css.map");
        public static readonly string favicon_ico = Url("favicon.ico");
        public static readonly string main_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/main.min.css") ? Url("main.min.css") : Url("main.css");
    }

    
    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public static partial class Bundles
    {
        public static partial class Scripts 
        {
            public static partial class esm 
            {
                public static class Assets
                {
                    public static readonly string popper_utils_js = T4MVCHelpers.ProcessAssetPath("~/Scripts/esm/popper-utils.js"); 
                    public static readonly string popper_utils_min_js = T4MVCHelpers.ProcessAssetPath("~/Scripts/esm/popper-utils.min.js"); 
                    public static readonly string popper_js = T4MVCHelpers.ProcessAssetPath("~/Scripts/esm/popper.js"); 
                    public static readonly string popper_min_js = T4MVCHelpers.ProcessAssetPath("~/Scripts/esm/popper.min.js"); 
                }
            }
            public static partial class umd 
            {
                public static class Assets
                {
                    public static readonly string popper_utils_js = T4MVCHelpers.ProcessAssetPath("~/Scripts/umd/popper-utils.js"); 
                    public static readonly string popper_utils_min_js = T4MVCHelpers.ProcessAssetPath("~/Scripts/umd/popper-utils.min.js"); 
                    public static readonly string popper_js = T4MVCHelpers.ProcessAssetPath("~/Scripts/umd/popper.js"); 
                    public static readonly string popper_min_js = T4MVCHelpers.ProcessAssetPath("~/Scripts/umd/popper.min.js"); 
                }
            }
            public static class Assets
            {
                public static readonly string bootstrap_bundle_js = T4MVCHelpers.ProcessAssetPath("~/Scripts/bootstrap.bundle.js"); 
                public static readonly string bootstrap_bundle_min_js = T4MVCHelpers.ProcessAssetPath("~/Scripts/bootstrap.bundle.min.js"); 
                public static readonly string bootstrap_js = T4MVCHelpers.ProcessAssetPath("~/Scripts/bootstrap.js"); 
                public static readonly string bootstrap_min_js = T4MVCHelpers.ProcessAssetPath("~/Scripts/bootstrap.min.js"); 
                public static readonly string jquery_3_4_1_intellisense_js = T4MVCHelpers.ProcessAssetPath("~/Scripts/jquery-3.4.1.intellisense.js"); 
                public static readonly string jquery_3_4_1_js = T4MVCHelpers.ProcessAssetPath("~/Scripts/jquery-3.4.1.js"); 
                public static readonly string jquery_3_4_1_min_js = T4MVCHelpers.ProcessAssetPath("~/Scripts/jquery-3.4.1.min.js"); 
                public static readonly string jquery_3_4_1_slim_js = T4MVCHelpers.ProcessAssetPath("~/Scripts/jquery-3.4.1.slim.js"); 
                public static readonly string jquery_3_4_1_slim_min_js = T4MVCHelpers.ProcessAssetPath("~/Scripts/jquery-3.4.1.slim.min.js"); 
                public static readonly string jquery_validate_js = T4MVCHelpers.ProcessAssetPath("~/Scripts/jquery.validate.js"); 
                public static readonly string jquery_validate_min_js = T4MVCHelpers.ProcessAssetPath("~/Scripts/jquery.validate.min.js"); 
                public static readonly string jquery_validate_unobtrusive_js = T4MVCHelpers.ProcessAssetPath("~/Scripts/jquery.validate.unobtrusive.js"); 
                public static readonly string jquery_validate_unobtrusive_min_js = T4MVCHelpers.ProcessAssetPath("~/Scripts/jquery.validate.unobtrusive.min.js"); 
                public static readonly string modernizr_2_8_3_js = T4MVCHelpers.ProcessAssetPath("~/Scripts/modernizr-2.8.3.js"); 
                public static readonly string popper_utils_js = T4MVCHelpers.ProcessAssetPath("~/Scripts/popper-utils.js"); 
                public static readonly string popper_utils_min_js = T4MVCHelpers.ProcessAssetPath("~/Scripts/popper-utils.min.js"); 
                public static readonly string popper_js = T4MVCHelpers.ProcessAssetPath("~/Scripts/popper.js"); 
                public static readonly string popper_min_js = T4MVCHelpers.ProcessAssetPath("~/Scripts/popper.min.js"); 
            }
        }
        public static partial class Content 
        {
            public static class Assets
            {
                public static readonly string bootstrap_grid_css = T4MVCHelpers.ProcessAssetPath("~/Content/bootstrap-grid.css");
                public static readonly string bootstrap_grid_min_css = T4MVCHelpers.ProcessAssetPath("~/Content/bootstrap-grid.min.css");
                public static readonly string bootstrap_reboot_css = T4MVCHelpers.ProcessAssetPath("~/Content/bootstrap-reboot.css");
                public static readonly string bootstrap_reboot_min_css = T4MVCHelpers.ProcessAssetPath("~/Content/bootstrap-reboot.min.css");
                public static readonly string bootstrap_css = T4MVCHelpers.ProcessAssetPath("~/Content/bootstrap.css");
                public static readonly string bootstrap_min_css = T4MVCHelpers.ProcessAssetPath("~/Content/bootstrap.min.css");
                public static readonly string main_css = T4MVCHelpers.ProcessAssetPath("~/Content/main.css");
            }
        }
    }
}

[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
internal static class T4MVCHelpers {
    // You can change the ProcessVirtualPath method to modify the path that gets returned to the client.
    // e.g. you can prepend a domain, or append a query string:
    //      return "http://localhost" + path + "?foo=bar";
    private static string ProcessVirtualPathDefault(string virtualPath) {
        // The path that comes in starts with ~/ and must first be made absolute
        string path = VirtualPathUtility.ToAbsolute(virtualPath);
        
        // Add your own modifications here before returning the path
        return path;
    }

    private static string ProcessAssetPathDefault(string virtualPath) {
        // The path that comes in starts with ~/ and should retain this prefix
        return virtualPath;
    }

    // Calling ProcessVirtualPath through delegate to allow it to be replaced for unit testing
    public static Func<string, string> ProcessVirtualPath = ProcessVirtualPathDefault;
    public static Func<string, string> ProcessAssetPath = ProcessAssetPathDefault;

    // Calling T4Extension.TimestampString through delegate to allow it to be replaced for unit testing and other purposes
    public static Func<string, string> TimestampString = System.Web.Mvc.T4Extensions.TimestampString;

    // Logic to determine if the app is running in production or dev environment
    public static bool IsProduction() { 
        return (HttpContext.Current != null && !HttpContext.Current.IsDebuggingEnabled); 
    }
}





#endregion T4MVC
#pragma warning restore 1591, 3008, 3009, 0108, 0114


