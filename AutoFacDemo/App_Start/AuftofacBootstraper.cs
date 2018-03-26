using Autofac;
using Autofac.Integration.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AutoFacDemo.App_Start
{
    public static class AuftofacBootstraper
    {
        public static void InitializeAutofac()
        {

            // First we'll register the MVC/WCF stuff...
            var builder = new ContainerBuilder();


            var assemblys = AppDomain.CurrentDomain.GetAssemblies().ToList();

            builder.RegisterControllers(assemblys.ToArray());

            builder.RegisterModule<AutofacServiceModule>();

            // MVC - Set the dependency resolver to be Autofac.
            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));

        }
    }
}