using Autofac;
using AutoFac.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AutoFacDemo.App_Start
{
    public class AutofacServiceModule : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            var baseType = typeof(IDependency);

            builder.RegisterAssemblyTypes(typeof(AutofacServiceModule).Assembly)
                   .Where(t => baseType.IsAssignableFrom(t) && t != baseType)
                   .AsImplementedInterfaces().InstancePerRequest();

            base.Load(builder);
        }
    }
}