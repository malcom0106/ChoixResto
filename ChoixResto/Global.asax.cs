using ChoixResto.Dal;
using ChoixResto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace ChoixResto
{
    public class MvcApplication : System.Web.HttpApplication
    {
        private DalSondage dalSondage = new DalSondage();
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            dalSondage.VerifierSondageDuJour();
        }
    }
}
