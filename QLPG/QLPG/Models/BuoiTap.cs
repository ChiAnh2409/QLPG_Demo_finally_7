//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QLPG.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class BuoiTap
    {
        public int id_BT { get; set; }
        public Nullable<int> id_CTDKGoiTap { get; set; }
        public Nullable<System.DateTime> NgayThamGia { get; set; }
        public Nullable<bool> DaDiemDanh { get; set; }
    
        public virtual ChiTietDK_GoiTap ChiTietDK_GoiTap { get; set; }
    }
}
