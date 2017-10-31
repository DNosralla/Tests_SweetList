using Autofac;
using Autofac.Integration.Mvc;
using Autofac.Integration.WebApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace SweetList.Web
{
    public static class AutofacConfig
    {
        public static void Build()
        {
            var builder = new ContainerBuilder();
   
            // Get your HttpConfiguration.
            var config = GlobalConfiguration.Configuration;

            // Register your Web API controllers.
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());

            // Register your MVC controllers.
            builder.RegisterControllers(Assembly.GetExecutingAssembly());

            builder.RegisterType<SweetList.Entity.SweetListDbContext>().InstancePerLifetimeScope();
            builder.RegisterType<SweetList.Repository.EF.CustomerRepository>().AsImplementedInterfaces().InstancePerLifetimeScope();
            builder.RegisterType<SweetList.Repository.EF.CountryRepository>().AsImplementedInterfaces().InstancePerLifetimeScope();
            builder.RegisterType<Utils.CountryListCache>().SingleInstance();

            // Set the dependency resolver to be Autofac.
            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }
    }
}