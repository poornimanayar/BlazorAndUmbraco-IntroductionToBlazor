using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Umbraco.Headless.Client.Net.Delivery;

namespace Blazor.UmbracoHeadless
{
    public static class HeartCoreService
    {
        public static IServiceCollection AddUmbracoHeadlessContentDelivery(this IServiceCollection services,
   string projectAlias, string apiKey = null)
        {
            services.AddSingleton
                (string.IsNullOrEmpty(apiKey)
                ? new ContentDeliveryService(projectAlias)
                : new ContentDeliveryService(projectAlias, apiKey));
            return services;
        }
    }
}
