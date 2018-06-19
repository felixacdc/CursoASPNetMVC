using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace AnotacionesDeData.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bunbles)
        {
            bunbles.Add(new ScriptBundle("~/bunbles/jquery").Include("~/Scripts/jquery-{version}.js"));
            bunbles.Add(new ScriptBundle("~/bunbles/jqueryval").Include("~/Scripts/jquery.validate*"));
            bunbles.Add(new ScriptBundle("~/bunbles/jqueryvalunobtrusive").Include("~/Scripts/jquery.validate.unobtrusive.min.js"));
        }
    }
}