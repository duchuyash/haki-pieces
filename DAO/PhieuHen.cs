//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAO
{
    using System;
    using System.Collections.Generic;
    
    public partial class PhieuHen
    {
        public int MaPH { get; set; }
        public int MaHD { get; set; }
        public Nullable<int> MaTV { get; set; }
        public string DiaChiGiao { get; set; }
        public Nullable<System.DateTime> NgayHen { get; set; }
        public Nullable<bool> TrangThai { get; set; }
    
        public virtual HoaDon HoaDon { get; set; }
        public virtual ThanhVien ThanhVien { get; set; }
    }
}
