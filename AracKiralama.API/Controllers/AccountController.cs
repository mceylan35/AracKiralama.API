using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.Results;
using System.Web.Routing;
using AracKiralama.Bll;
using AracKiralama.Dal.Concrete.EntityFramework.Repository;
using AracKiralama.Entities;

namespace AracKiralama.API.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    [RoutePrefix("api/account")]
    public class AccountController : ApiController
    {
        [HttpPost]
        [Route("Login")]
        public IHttpActionResult KullaniciGiris([FromBody]KullaniciGiris kul)
        {
            try
            {
                using (var kullaniciManager = new KullaniciManager(new EfKullaniciRepository()))
                {
                    var kullanici = kullaniciManager.KullaniciGiris(kul.Eposta, kul.Sifre);
                    return Ok(kullanici);
                }

            }



            catch (Exception e)
            {
                return Unauthorized();
            }
        }
    }
}
