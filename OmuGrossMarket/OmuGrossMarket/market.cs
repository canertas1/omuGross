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
    
    public partial class market
    {
        public int musteriID { get; set; }
        public int tedarikciID { get; set; }
        public int satisID { get; set; }
        public int urunID { get; set; }
        public int marketID { get; set; }
    
        public virtual musteri musteri { get; set; }
        public virtual perakendeSatis perakendeSatis { get; set; }
        public virtual tedarikci tedarikci { get; set; }
        public virtual urun urun { get; set; }
    }
}