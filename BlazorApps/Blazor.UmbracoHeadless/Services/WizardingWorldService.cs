using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Umbraco.Headless.Client.Net.Delivery;
using Umbraco.Headless.Client.Net.Delivery.Models;

namespace Blazor.UmbracoHeadless.Services
{
    public class WizardingWorldService
    {
        private readonly ContentDeliveryService _contentDeliveryService;

        public WizardingWorldService(ContentDeliveryService contentDeliveryService)
        {
            _contentDeliveryService = contentDeliveryService;
        }      

        public async Task<IEnumerable<Content>> GetWizardingWorldCharacters()
        {
            var content = await _contentDeliveryService.Content.GetRoot();
            return content;

        }
    }
}
