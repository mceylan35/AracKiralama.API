//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AracKiralama.API.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class Sirket
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Sirket()
        {
            this.Arac = new HashSet<Arac>();
            this.Kullanici = new HashSet<Kullanici>();
        }
    
        public int SirketId { get; set; }
        public string SirketAdi { get; set; }
        public string Sehir { get; set; }
        public string Adres { get; set; }
        public Nullable<int> AracSayisi { get; set; }
        public Nullable<int> SirketPuani { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Arac> Arac { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Kullanici> Kullanici { get; set; }
    }
}
