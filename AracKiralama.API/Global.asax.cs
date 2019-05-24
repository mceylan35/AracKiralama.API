
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace AracKiralama.API
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {

           // AutoMapper.Mapper.Initialize(cfg => cfg.AddProfile<AutomapperProfile>());
            var formatters = GlobalConfiguration.Configuration.Formatters;
            formatters.Remove(formatters.XmlFormatter);


            //  GlobalConfiguration.Configuration.Formatters.Clear();
            //  GlobalConfiguration.Configuration.Formatters.Add(new JsonNetFormatter(jsonSerializerSettings));

            GlobalConfiguration.Configure(WebApiConfig.Register);

        }
    }
}
