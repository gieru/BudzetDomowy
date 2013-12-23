using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Raven;
using Raven.Client;
using Raven.Client.Embedded;

namespace BudzetDomowy
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        private static EmbeddableDocumentStore docStore;
        public static IDocumentStore DocumentStore
        {
            get { return docStore; }
        }

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            docStore = new EmbeddableDocumentStore() {
                DataDirectory = @"~\App_Data\Database"
            };
            docStore.Initialize();
        }
    }
}