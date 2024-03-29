﻿using System.Web;
using System.Web.Optimization;

namespace MVCBootstrapDemo
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
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css",
                      "~/Content/fontawesome.css"));
            bundles.Add(new StyleBundle("~/Content/css1").Include(
                      "~/Content/bootswatch-lux.css",
                      "~/Content/site.css",
                      "~/Content/fontawesome.css"));
            bundles.Add(new StyleBundle("~/Content/css2").Include(
                      "~/Content/bootswatch-united.css",
                      "~/Content/site.css",
                      "~/Content/fontawesome.css"));
            bundles.Add(new StyleBundle("~/Content/css3").Include(
                      "~/Content/bootswatch-superhero.css",
                      "~/Content/site.css",
                      "~/Content/fontawesome.css"));

            //bundles.Add(new StyleBundle("~/Content/css").IncludeDirectory("~/Content", "*.css"));
        }
    }
}
