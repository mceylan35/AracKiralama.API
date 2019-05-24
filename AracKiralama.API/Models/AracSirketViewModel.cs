using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AracKiralama.API.Entities;

namespace AracKiralama.API.Models
{
    public class AracSirketViewModel
    {
        public List<Arac> Araclar = new List<Arac>();
        public List<Sirket> Sirkets=new List<Sirket>();
    }
}