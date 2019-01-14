using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web.Http;
using Microsoft.Owin.Security.OAuth;
using Newtonsoft.Json.Serialization;
using SmartphoneShop.Interfaces;
using SmartphoneShop.Repository;
using SmartphoneShop.Resolver;
using Unity;
using Unity.Lifetime;

namespace SmartphoneShop
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            // Configure Web API to use only bearer token authentication.
            config.SuppressDefaultHostAuthentication();
            config.Filters.Add(new HostAuthenticationFilter(OAuthDefaults.AuthenticationType));

            // Web API routes
            config.MapHttpAttributeRoutes();
            
            // Unity
            var container = new UnityContainer();
            container.RegisterType<IShopRepository, ShopRepository>(new HierarchicalLifetimeManager());
            container.RegisterType<ISmartphoneRepository, SmartphoneRepository>(new HierarchicalLifetimeManager());
            config.DependencyResolver = new UnityResolver(container);


            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
