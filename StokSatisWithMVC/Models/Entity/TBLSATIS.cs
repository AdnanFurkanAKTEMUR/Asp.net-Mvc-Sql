//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StokSatisWithMVC.Models.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class TBLSATIS
    {
        public int SATISID { get; set; }
        public Nullable<int> URUN { get; set; }
        public Nullable<int> MUSTERI { get; set; }
        public Nullable<int> ADET { get; set; }
        public Nullable<decimal> FIYAT { get; set; }
    
        public virtual TBLMUSTERI TBLMUSTERI { get; set; }
        public virtual TBLURUNLER TBLURUNLER { get; set; }
    }
}
