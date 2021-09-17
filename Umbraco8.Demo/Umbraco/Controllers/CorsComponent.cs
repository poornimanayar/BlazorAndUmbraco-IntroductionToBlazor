
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;
using Umbraco.Core;
using Umbraco.Core.Composing;

namespace Umbraco.Controllers
{
    public class CorsComponent : IComponent
    {
        /// <summary>Initializes the component.</summary>
        public void Initialize()
        {
            //enable all origins, headers and methods
            var corsAttr = new EnableCorsAttribute("*", "*", "*");
            GlobalConfiguration.Configuration.EnableCors(corsAttr);
        }

        /// <summary>Terminates the component.</summary>
        public void Terminate()
        {
        }
    }

    public class CorsComposer : IUserComposer
    {
        /// <summary>Compose.</summary>
        public void Compose(Composition composition)
        {
            composition.Components().Append<CorsComponent>();
        }
    }
}