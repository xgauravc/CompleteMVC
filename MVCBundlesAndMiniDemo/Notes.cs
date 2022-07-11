using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCBundlesAndMiniDemo
{
    

    //A browser(Chrome) can send a maximum of 6 connection per host at a time.
    //So while loading first 6 links will get loaded and rest in next turn.
    //This degrades the performance of the appplication

    /*
     * Bundling - It is used for increasing the performance of the application
     *  Bundling reduces the number of requests sends from browser
     *  simply sare links ka ek bundle banakar usko call karo to number of requests kam ho jaenge.
     *  But doing this will make rquest heavy .
     *  For this minification is used
     *  
     *  In asp-net MVC we can make bundle for CSS and JS
     *  
     *  How to create bundle :
     *  
     *      Hum " BundleConfig " file ka use karte hai
     *      
     *      " BundleCollection " class is used from this file which is in 
     *      namespace " System.Web.Optimization "
     *      
     *      Nuget package name - asp.net.web.optimization
     *      
     *      This class has a method to add new Bundle
     *      
     *      Bundle needs to be registered in " Global.asax "
     *      
     *      For JS we use ScriptBundle
     *      For CSS we use StyleBundle
     *      
     *  How to render bundle:
     *      
     *      For JS Bundle use @Scripts.Bundle(path)
     *      For CSS Bundle use @Styles.Bundle(path)
     *      
     *      available in - System.Web.Optimization
     * 
    
     */

    /*
     * Minification is a process of removing unwanted data without changins its functionality
     * 
     * This removal includes - 
     *      - Comments
     *      - Extra spaces
     *      - Convert large variable name to small name
     *      
     *      
     * already included with bundling no need to do anything else.
     * if we select MVC template they create it for us.
     
     */

    public class Notes
    {
    }
}