using System.Web;
using System.Web.Optimization;

namespace WebApplication4
{
    public class BundleConfig
    {
        // 如需「搭配」的詳細資訊，請瀏覽 http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                         "~/bower_components/jquery.min.js",
                         "~/bower_components/moment/min/moment.min.js",
                         "~/bower_components/fullcalendar/dist/fullcalendar.min.js",
                         "~/bower_components/chosen/chosen.jquery.min.js",
                         "~/bower_components/colorbox/jquery.colorbox-min.js",
                         "~/bower_components/responsive-tables/responsive-tables.js",
                         "~/bower_components/bootstrap-tour/build/js/bootstrap-tour.min.js",
                         "~/js/jquery.cookie.js",
                         "~/js/jquery.dataTables.min.js",
                         "~/js/jquery.noty.js",
                         "~/js/jquery.raty.min.js",
                         "~/js/jquery.iphone.toggle.js",
                         "~/js/jquery.autogrow-textarea.js",
                         "~/js/jquery.uploadify-3.1.min.js",
                         "~/js/jquery.history.js",
                         "~/js/charisma.js",
                         "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // 使用開發版本的 Modernizr 進行開發並學習。然後，當您
            // 準備好實際執行時，請使用 http://modernizr.com 上的建置工具，只選擇您需要的測試。
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(                      
                      "~/css/bootstrap-cerulean.min.css",
                      "~/css/charisma-app.css",
                      "~/bower_components/fullcalendar.css",
                      "~/bower_components/fullcalendar.print.css",
                      "~/bower_components/chosen.min.css",
                      "~/bower_components/colorbox.css",
                      "~/bower_components/responsive-tables.css",
                      "~/bower_components/bootstrap-tour.min.css",
                      "~/css/jquery.noty.css",
                      "~/css/noty_theme_default.css",
                      "~/css/elfinder.min.css",
                      "~/css/elfinder.theme.css",
                      "~/css/jquery.iphone.toggle.css",
                      "~/css/uploadify.css",
                      "~/css/animate.min.css"));
        }
    }
}
