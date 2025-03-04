﻿using System.Web;
using System.Web.Optimization;

namespace MyContacts
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/js/lib/jquery.min.js"));
            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                   "~/js/lib/bootstrap.min.js"
                   ));
            bundles.Add(new ScriptBundle("~/bundles/datatables").Include(
                        "~/js/lib/jquery.dataTables.min.js",
                        "~/js/lib/dataTables.bootstrap.min.js",
                        "~/js/lib/dataTables.colReorder.min.js"));

            
         

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/css/bootstrap.min.css",
                      
                        "~/css/jquery.dataTables.min.css",
                         "~/css/jquery.daTables_themeroller.css",
                          "~/css/dataTables.bootstrap.min.css",
                           "~/css/colReorder.bootstrap.min.css",
                        "~/css/site.css"));
        }
    }
}
