using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace MVCBundlesAndMiniDemo.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundle(BundleCollection bundles)
        {



            /* using include*/
            //var bundle = new ScriptBundle("~/bundles/js");
            //bundle.Include("~/Content/JS/Javascript.js",
            //    "~/Content/JS/Javascript1.js",
            //    "~/Content/JS/Javascript2.js",
            //     "~/Content/JS/Javascript3.js",
            //   "~/Content/JS/Javascript4.js");
            //bundles.Add(bundle);


            /* using Includefor*/

            bundles.Add(new ScriptBundle("~/bundles/js").IncludeDirectory("~/Content/JS","*.js"));


            /* bundle using include for css*/

            var bundle = new StyleBundle("~/bundles/css");

            bundle.Include("~/Content/Styles/StyleSheet1.css", "~/Content/Styles/StyleSheet2.css");

            bundles.Add(bundle);

            

            //bundle doesn't start in debug mode.

            BundleTable.EnableOptimizations = true;//for enabling bundle in debug mode
        }
    }
}