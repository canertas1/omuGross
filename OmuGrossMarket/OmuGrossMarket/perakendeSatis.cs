//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OmuGrossMarket
{
    using System;
    using System.Collections.Generic;
    
    public partial class perakendeSatis
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public perakendeSatis()
        {
            this.market = new HashSet<market>();
            this.pesinSatis = new HashSet<pesinSatis>();
            this.veresiye = new HashSet<veresiye>();
        }
    
        public int satisID { get; set; }
        public int urunID { get; set; }
        public System.DateTime satisTarih { get; set; }
        public int satisMiktar { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<market> market { get; set; }
        public virtual urun urun { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<pesinSatis> pesinSatis { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<veresiye> veresiye { get; set; }
    }
}