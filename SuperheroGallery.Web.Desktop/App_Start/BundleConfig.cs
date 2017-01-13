using System.Web;
using System.Web.Optimization;

namespace SuperheroGallery.Web.Desktop
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            //bundles.IgnoreList.Ignore("~/app/superhero-edit/*.js");

            bundles.Add(new ScriptBundle("~/bundles/bower_components")
                .Include("~/bower_components/angular/angular.js")
                .Include("~/bower_components/angular-ui-router/release/angular-ui-router.js")
                .Include("~/bower_components/angular-material/angular-material.js")
                .Include("~/bower_components/angular-animate/angular-animate.js")
                .Include("~/bower_components/angular-aria/angular-aria.js")
                .Include("~/bower_components/angular-messages/angular-messages.js"));

            bundles.Add(new ScriptBundle("~/bundles/app")
                .Include("~/app/app.module.js")
                .IncludeDirectory("~/app", "*.module.js", true)
                .IncludeDirectory("~/app", "*.js", true));


            bundles.Add(new ScriptBundle("~/bundles/jquery")
                .Include("~/Scripts/jquery-{version}.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr")
                .Include("~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap")
                .Include("~/Scripts/bootstrap.js", "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css")
                .Include("~/Content/bootstrap.css", "~/Content/site.css")
                .Include("~/bower_components/angular-material/angular-material.css")
                .Include("~/app/content/styles/rating.css"));
        }
    }
}
