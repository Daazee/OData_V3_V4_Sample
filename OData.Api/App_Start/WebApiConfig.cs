using OData.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
//using ODataV3 = System.Web.Http.OData;

using Microsoft.AspNet.OData.Builder; //Odata V4
using Microsoft.AspNet.OData.Extensions; //Odata V4

namespace OData.Api
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // OData V3 Route

            //ODataV3.Builder.ODataModelBuilder builder3 = new ODataV3.Builder.ODataConventionModelBuilder();

            //builder3.EntitySet<Product>("Products");
            ////The MapODataRoute function is deprecated in WebAPI 2.2,
            ////but I haven't found an alternative for supporting OData 3.
            //config.Routes.MapODataRoute(
            //    routeName: "ODataRoute",
            //    routePrefix: null,
            //    model: builder3.GetEdmModel());


            //OData Version 4 Route
            ODataModelBuilder builder = new ODataConventionModelBuilder();
            builder.EntitySet<Product>("Products"); //Entity set Products must matches name of controller
            config.MapODataServiceRoute(
                routeName: "ODataRoute",
                routePrefix: null,
                model: builder.GetEdmModel());

        }
    }
}
