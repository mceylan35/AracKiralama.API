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
            try
            {
                using (var sirketManager=new SirketManager(new EfSirketRepository()))
                {
                    

                    return Ok(sirketManager.AracAylikGunlukYaptigiKm());
                }
            }
            catch (Exception e)
            {
                return NotFound();
            }
         
        }
        [HttpGet]
        [Route("aylikgelir")]
        public IHttpActionResult AylikKiraKazanc()
        {
            try
            {
                using (var aracManager=new AracManager(new EfAracRepository()))
                {
                    return Ok(aracManager.AylikKiraKazanc());
                }
            }
            catch (Exception e)
            {
                return NotFound();
            }
         
        }
        [HttpGet]
        [Route("gunkiraort")]
        public IHttpActionResult GunlukOrtKiralanArac()
        {
            try
            {
                using (var kiralikManager=new KiralikManager(new EfKiralikRepository()))
            {
                return Ok(kiralikManager.GunlukKiralananOrtalamaAracSayisi());
            }

          

            }
            catch (Exception e)
            {
                return NotFound();
            }

        }
        [HttpGet]
        [Route("kmasan")]
        public IHttpActionResult GunlukKmAsanlarOrt()
        {
            try
            {
                using (var aracManager=new AracManager(new EfAracRepository()))
                {
                    return Ok(aracManager.GunlukKmAsanlarOrt());
                }
            }
            catch (Exception e)
            {
                return NotFound();
            }
        }








    }
}
