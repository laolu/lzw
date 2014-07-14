using System.Web;
using System.Web.Optimization;

namespace Platform.Web
{
    public class BundleConfig
    {
        // 有关 Bundling 的详细信息,请访问 http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/js").Include(
                        "~/Scripts/jquery-{version}.js",
                        "~/Scripts/jquery-ui-{version}.js",
                        "~/Scripts/jquery.validate*",
                        "~/Scripts/jquery.unobtrusive*",
                        "~/Scripts/bootstrap.js",
                        "~/Scripts/jquery.cookie.js",
                        "~/Scripts/jquery.placeholder.js",
                        "~/Scripts/bootstrap-datepicker.js",
                         "~/Scripts/locales/bootstrap-datepicker.zh-CN.js",
                        "~/Scripts/daterangepicker.js", 
                        "~/Scripts/fullcalendar.js",
                        "~/Scripts/gcal.js",
                        "~/Scripts/DataTables/jquery.dataTables.js",
                        "~/Scripts/DataTables/dataTables.tableTools.js",
                        "~/Scripts/DataTables/dataTables.editor.min.js",
                        "~/Scripts/DataTables/dataTables.bootstrapV2.js",
                        "~/Scripts/DataTables/editor.bootstrap.js",
                        "~/Scripts/DataTables/jquery.dataTables.columnFilter.js", 
                        "~/Scripts/app.js",
                        
                        "~/Scripts/index.js", 
                        
                        //"~/Scripts/jquery.validate*", 
                        //"~/Scripts/jquery.validate*", 
                        //"~/Scripts/jquery.validate*", 
                        //"~/Scripts/jquery.validate*", 
                        "~/Scripts/common.js"
                        ));
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new StyleBundle("~/css").Include(
                "~/Content/bootstrap/bootstrap.css",
                "~/Content/bootstrap/bootstrap-responsive.css",
                "~/Content/bootstrap-datepicker.css",
                "~/Content/daterangepicker-bs2.css",
                "~/Content/fullcalendar.css",
                "~/Content/fullcalendar.print.css",
                "~/Content/DataTables/css/jquery.dataTables.css",
                "~/Content/DataTables/css/dataTables.tableTools.css",
                "~/Content/DataTables/css/dataTables.bootstrap.css",
                "~/Content/DataTables/css/editor.bootstrap.css",
                "~/Content/font-awesome.css",
                "~/Content/login.css",
                "~/Content/style-metro.css",
                //"~/Content/site.css",
                //"~/Content/site.css",
                "~/Content/style-responsive.css",
                "~/Content/default.css",
                "~/Content/style.css"));

            bundles.Add(new StyleBundle("~/Content/themes/base/css").Include(
                        "~/Content/themes/base/jquery.ui.core.css",
                        "~/Content/themes/base/jquery.ui.resizable.css",
                        "~/Content/themes/base/jquery.ui.selectable.css",
                        "~/Content/themes/base/jquery.ui.accordion.css",
                        "~/Content/themes/base/jquery.ui.autocomplete.css",
                        "~/Content/themes/base/jquery.ui.button.css",
                        "~/Content/themes/base/jquery.ui.dialog.css",
                        "~/Content/themes/base/jquery.ui.slider.css",
                        "~/Content/themes/base/jquery.ui.tabs.css",
                        "~/Content/themes/base/jquery.ui.datepicker.css",
                        "~/Content/themes/base/jquery.ui.progressbar.css",
                        "~/Content/themes/base/jquery.ui.theme.css"));
        }
    }
}