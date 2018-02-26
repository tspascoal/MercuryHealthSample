using MecuryHealth;
using MercuryHealth.Web.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace MercuryHealth.Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            // Database.SetInitializer(new DropCreateDatabaseIfModelChanges<ApplicationDbContext>());

            Database.SetInitializer<ApplicationDbContext>(null);

            // Application Insights - Track Telemetry by version
            //TelemetryConfiguration.Active.ContextInitializers.Add(new Helper.VersionTelemetry());
            //TelemetryConfiguration.Active.TelemetryInitializers.Add(new Helper.TelemetryStartUp());

        }
    }
}
