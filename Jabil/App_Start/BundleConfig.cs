using System.Web;
using System.Web.Optimization;

namespace Jabil
{
	public class BundleConfig
	{
		// For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
		public static void RegisterBundles(BundleCollection bundles)
		{
			bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
						"~/Scripts/jquery-{version}.js"));

			bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
						"~/Scripts/jquery.validate*"));

			// Use the development version of Modernizr to develop with and learn from. Then, when you're
			// ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
			bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
						"~/Scripts/modernizr-*"));

			bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
					  "~/Scripts/bootstrap.js",
					  "~/Scripts/respond.js"));

			bundles.Add(new StyleBundle("~/Content/css").Include(
					  "~/Content/bootstrap.css",
					  "~/Content/site.css"));

			bundles.Add(new ScriptBundle("~/bundles/datatables").Include(
				"~/vendors/datatables/datatables.min.js", 
				"~/vendors/datatables/DataTables-1.10.16/js/jquery.dataTables.min.js",
				"~/vendors/datatables/Buttons-1.5.1/js/dataTables.buttons.min.js",
				"~/vendors/datatables/DataTables-1.10.16/js/dataTables.bootstrap.min.js",
				"~/vendors/datatables/Buttons-1.5.1/js/buttons.flash.min.js",
				"~/vendors/datatables/JSZip-2.5.0/jszip.min.js",
				"~/vendors/datatables/pdfmake-0.1.32/pdfmake.min.js",
				"~/vendors/datatables/pdfmake-0.1.32/vfs_fonts.js",
				"~/vendors/datatables/Buttons-1.5.1/js/buttons.html5.min.js",
				"~/vendors/datatables/Buttons-1.5.1/js/buttons.print.min.js"));

			bundles.Add(new StyleBundle("~/vendors/datatables").Include(
				"~/vendors/datatables/DataTables-1.10.16/css/dataTables.bootstrap.min.css",
				"~/vendors/datatables/Buttons-1.5.1/css/buttons.dataTables.min.css"));
		}
	}
}
