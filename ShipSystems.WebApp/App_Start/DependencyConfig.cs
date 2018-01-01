using Autofac;
using Autofac.Integration.Web;
using Enexure.MicroBus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;

namespace ShipSystems.WebApp.App_Start
{
    public class DependencyConfig
    {
        public static void RegisterDependencies()
        {
            var builder = new ContainerBuilder();

            //builder.RegisterApiControllers(Assembly.GetExecutingAssembly());

            // OPTIONAL: Register the Autofac filter provider.
            //builder.RegisterWebApiFilterProvider(config);

            builder.RegisterModule(new ShipSystemsDomainModule());

            var container = builder.Build();

            //config.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }
    }

    public class ShipSystemsDomainModule : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            var busBuilder = new BusBuilder();

            base.Load(builder);
        }
    }
}