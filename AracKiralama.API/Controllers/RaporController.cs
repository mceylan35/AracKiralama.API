using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using AutoMapper;
using AracKiralama.API.Entities;
using AracKiralama.API.Models;
using AracKiralama.Bll;
using AracKiralama.Dal.Concrete.EntityFramework.Repository;

namespace AracKiralama.API.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    [RoutePrefix("api/rapor")]
    public class RaporController : ApiController
    {
        private AracManager aracManager = new AracManager(new EfAracRepository());
        private KiralikManager kiralikManager = new KiralikManager(new EfKiralikRepository());
        private SirketManager sirketManager = new SirketManager(new EfSirketRepository());

        [HttpGet]
        [Route("aygunkm")]
        public IHttpActionResult AracYaptigiGunlukKm()
        {
           var yapilankm=sirketManager.AracAylikGunlukYaptigiKm();
            return Ok(yapilankm);
        }
        [HttpGet]
        [Route("aylikkazanc")]
        public IHttpActionResult AylikKiraKazanc()
        {
            
           var aylikgelir= aracManager.AylikKiraKazanc();
            return Ok(aylikgelir);
        }

     






    }
}
