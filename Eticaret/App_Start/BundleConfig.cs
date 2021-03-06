﻿using System.Web;
using System.Web.Optimization;

namespace Eticaret
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
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
            bundles.Add(new StyleBundle("~/admin/styles").
                Include("~/content/styles/admin.css").
                Include("~/content/styles/bootstrap.css"));

            bundles.Add(new ScriptBundle("~/admin/scripts").
               Include("~/content/scripts/jquery-1.11.2.min.js").
               Include("~/content/scripts/form.js"));

            //bundles.Add(new ScriptBundle("~/Scripts").Include(
            // "~/Scripts/jquery.js",
            // "~/Scripts/bootstrap.min.js",
            //  "~/Scripts/jquery.scrollUp.min.js",
            //   "~/Scripts/price-range.js",
            //    "~/Scripts/jquery.prettyPhoto.js",
            //     "~/Scripts/main.js"));
            //bundles.Add(new StyleBundle("~/Content").Include(
            //    "~/Content/bootstrap.min.css",
            //    "~/Content/font-awesome.min.css",
            //    "~/Content/prettyPhoto.css",
            //    "~/Content/prettyPhoto.css",
            //    "~/Content/animate.css",
            //    "~/Content/main.css",
            //    "~/Content/responsive.css"));
        }
    }
}
