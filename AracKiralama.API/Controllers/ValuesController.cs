using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web.Http;

using AutoMapper;
using Newtonsoft.Json;

namespace AracKiralama.API.Controllers
{
    public class ValuesController : ApiController
    {
        //public ValuesController()
        //{
        //    db.Configuration.ProxyCreationEnabled = false;
        //}
        //AracManager aracManager=new AracManager(new EfAracRepository());
        //AracKiralamaContext db=new AracKiralamaContext();

        //// GET api/values
        //public HttpResponseMessage Get()
        //{

        //    try
        //    {
        //        var response = new HttpResponseMessage(HttpStatusCode.OK);
        //        response.Content = new
        //            StringContent(JsonConvert.SerializeObject(aracManager.GetAll()));
        //        response.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
        //        return response;

        //    }
        //    catch (Exception e)
        //    {
        //        return new HttpResponseMessage(HttpStatusCode.BadGateway);
        //    }
            
            
        //}

        //// GET api/values/5
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST api/values
        //public void Post([FromBody]string value)
        //{
        //}

        //// PUT api/values/5
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE api/values/5
        //public void Delete(int id)
        //{
        //}
    }
}
