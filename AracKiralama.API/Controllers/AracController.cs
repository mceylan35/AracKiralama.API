using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web.Http;
using System.Web.Http.Description;

using AutoMapper;
using Newtonsoft.Json;
using System.Data.Objects.SqlClient;
namespace AracKiralama.API.Controllers
{
    [RoutePrefix("api/arac")]
    // [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class AracController : ApiController
    {
        //AracKiralamaContext db=new AracKiralamaContext();
        ////public AracController()
        ////{
        ////    db.Configuration.ProxyCreationEnabled = false;
        ////}
        //AracManager aracManager = new AracManager(new EfAracRepository());
     
      



        ////[HttpGet]
        ////[ResponseType(typeof(AracDTO))]
        ////public HttpResponsLieMessage Get()
        ////{
        ////    try
        ////    {
        ////        var response = new HttpResponseMessage(HttpStatusCode.OK);
        ////        response.Content = new
        ////            StringContent(JsonConvert.SerializeObject(Mapper.Map<AracDTO>(aracManager.GetAll())));
        ////        response.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
        ////        return response;

        ////    }
        ////    catch (Exception e)
        ////    {
        ////        return new HttpResponseMessage(HttpStatusCode.BadGateway);
        ////    }


        ////}

        //[HttpGet]
        ////[ResponseType(typeof(AracDTO))]
        //public IHttpActionResult Get()
        //{
        //    try
        //    {

        //        var araclar= Mapper.Map<List<AracDTO>>(aracManager.GetAll());
        //        return Ok(araclar);
        //    }
        //    catch (Exception e)
        //    {
        //        return BadRequest("hata oluştu");
        //    }


        //}

        //[HttpGet]
        ////[ResponseType(typeof(AracDTO))]
        //public IHttpActionResult Get(int id)
        //{
        //    try
        //    {

        //        var arac =Mapper.Map<AracDTO>(aracManager.Get(id));
        //        return Ok(arac);
        //    }
        //    catch (Exception e)
        //    {
        //        return BadRequest("araç bulunamadı");
        //    }


        //}
        //[Route("sil/{id}")]
        //[HttpDelete]
        //public IHttpActionResult AracSil(int id)
        //{
        //    try
        //    {
        //        aracManager.Delete(id);
        //        return Ok();
        //    }
        //    catch (Exception e)
        //    {
        //        return BadRequest();
        //    }
            
        //}

        //[HttpPut]
        //[Route("guncelle")]
        //public IHttpActionResult AracGuncelle(AracDTO arac)
        //{
        //    try
        //    {
        //       var garac= aracManager.Update(Mapper.Map<Arac>(arac));
        //        return Ok(garac);
        //    }
        //    catch (Exception e)
        //    {
        //        return BadRequest();
        //    }
        //}

        //[HttpPost]
        //[Route("ekle")]
        //public IHttpActionResult AracEkle(AracDTO arac)
        //{
        //    try
        //    {
        //        var garac = aracManager.Add(Mapper.Map<Arac>(arac));
        //        return Ok(garac);
        //    }
        //    catch (Exception e)
        //    {
        //        return BadRequest();
        //    }
        //}


    }
}
