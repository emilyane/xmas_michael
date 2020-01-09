using System.Web;
using System.Web.Optimization;

namespace Xmas
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            //bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
            //            "~/Scripts/jquery-{version}.js"));

            //bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
            //            "~/Scripts/jquery.validate*"));

            //// Use the development version of Modernizr to develop with and learn from. Then, when you're
            //// ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            //bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
            //            "~/Scripts/modernizr-*"));

            //bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
            //          "~/Scripts/bootstrap.js"));

            //bundles.Add(new StyleBundle("~/Content/css").Include(
            //          "~/Content/bootstrap.css",
            //          "~/Content/site.css"));


            bundles.Add(new ScriptBundle("~/javascript/js")
               .Include("~/js/jquery-2.2.3.min.js")
               );

            bundles.Add(new ScriptBundle("~/javascript/js")
               .Include("~/js/dscountdown.min.js")
               );

            bundles.Add(new ScriptBundle("~/javascript/js")
               .Include("~/js/jquery-ui.js")
               );

            bundles.Add(new ScriptBundle("~/javascript/js")
               .Include("~/js/move-top.js")
               );

            bundles.Add(new ScriptBundle("~/javascript/js")
              .Include("~/js/easing.js")
              );

            bundles.Add(new ScriptBundle("~/javascript/js")
             .Include("~/js/SmoothScroll.js")
             );


            bundles.Add(new ScriptBundle("~/Scripts/js")
             .Include("~/js/SmoothScroll.js")
             );

            bundles.Add(new ScriptBundle("~/Scripts/js")
             .Include("~/js/jquery.vide.min.js")
             );

            bundles.Add(new ScriptBundle("~/Scripts/js")
             .Include("~/js/jquery.mobile.custom.min.js")
             );

            bundles.Add(new ScriptBundle("~/Scripts/js")
             .Include("~/js/jquery.cm-overlay.js")
             );

            bundles.Add(new ScriptBundle("~/Scripts/js")
             .Include("~/js/jquery.tools.min.js")
             );

            bundles.Add(new StyleBundle("~/Content/css")
                .Include("~/Content/bootstrap.css",
                "~/css/style.css", "~/css/cm-overlay.css", "~/css/dscountdown.css", "~/css/font-awesome.css", "~/css/lightbox.css", "~/css/animate.css"));





        }
    }
}
