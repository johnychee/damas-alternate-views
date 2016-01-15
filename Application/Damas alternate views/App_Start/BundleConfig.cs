using System.Web;
using System.Web.Optimization;

namespace Damas_alternate_views
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        
        {
            BundleTable.EnableOptimizations = false;
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));
            bundles.Add(new ScriptBundle("~/Scripts/ADV2/js").Include(
                      "~/Content/ADV/worldLow.js"));
            bundles.Add(new StyleBundle("~/Content/ADV/css").Include(
                      "~/Content/ADV/bootstrap.min.css",
                      "~/Content/ADV/bootstrap-switch.min.css",
                      "~/Content/ADV/components.min.css",
                      "~/Content/ADV/custom.min.css",
                      "~/Content/ADV/daterangepicker.min.css",
                      "~/Content/ADV/font-awesome.min.css",
                      "~/Content/ADV/fullcalendar.min.css",
                      "~/Content/ADV/jqvmap.css",
                      "~/Content/ADV/layout.min.css",
                      "~/Content/ADV/morris.css",
                      "~/Content/ADV/plugins.min.css",
                      "~/Content/ADV/simple-line-icons.min.css",
                      "~/Content/ADV/uniform.default.css"));
            bundles.Add(new ScriptBundle("~/Scripts/ADV/js").Include(
                      "~/Content/ADV/amcharts.js",
                      "~/Content/ADV/ammap.js",
                      "~/Content/ADV/amstock.js",
                      "~/Content/ADV/app.min.js",
                      "~/Content/ADV/bootstrap-hover-dropdown.min.js",
                      "~/Content/ADV/bootstrap-switch.min.js",
                      "~/Content/ADV/bootstrap.min.js",
                      "~/Content/ADV/chalk.js",
                      "~/Content/ADV/dashboard.min.js",
                      "~/Content/ADV/daterangepicker.min.js",
                      "~/Content/ADV/fullcalendar.min.js",
                      "~/Content/ADV/jquery.blockui.min.js",
                      "~/Content/ADV/jquery.counterup.min.js",
                      "~/Content/ADV/jquery.easypiechart.min.js",
                      "~/Content/ADV/jquery.flot.categories.min.js",
                      "~/Content/ADV/jquery.flot.min.js",
                      "~/Content/ADV/jquery.flot.resize.min.js",
                      "~/Content/ADV/jquery.min.js",
                      "~/Content/ADV/jquery.slimscroll.min.js",
                      "~/Content/ADV/jquery.sparkline.min.js",
                      "~/Content/ADV/jquery.uniform.min.js",
                      "~/Content/ADV/jquery.vmap.europe.js",
                      "~/Content/ADV/jquery.vmap.germany.js",
                      "~/Content/ADV/jquery.vmap.js",
                      "~/Content/ADV/jquery.vmap.russia.js",
                      "~/Content/ADV/jquery.vmap.sampledata.js",
                      "~/Content/ADV/jquery.vmap.usa.js",
                      "~/Content/ADV/jquery.vmap.world.js",
                      "~/Content/ADV/jquery.waypoints.min.js",
                      "~/Content/ADV/js.cookie.min.js",
                      "~/Content/ADV/layout.min.js",
                      "~/Content/ADV/light.js",
                      "~/Content/ADV/moment.min.js",
                      "~/Content/ADV/morris.min.js",
                      "~/Content/ADV/patterns.js",
                      "~/Content/ADV/pie.js",
                      "~/Content/ADV/quick-sidebar.min.js",
                      "~/Content/ADV/radar.js",
                      "~/Content/ADV/raphael-min.js",
                      "~/Content/ADV/serial.js",
                      "~/Content/ADV/worldLow.js"));
        }
    }
}
