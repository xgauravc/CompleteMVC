using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using MVCBundlesAndMiniDemo.App_Start;
using System.Web.Optimization;

namespace MVCBundlesAndMiniDemo
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            //Register Bundle
            BundleConfig.RegisterBundle(BundleTable.Bundles);

            
        }
    }
}
