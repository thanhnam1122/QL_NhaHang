//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QL_NhaHang_ADO.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class ChiTietHoaDon
    {
        public string MAHOADON { get; set; }
        public string MAMONAN { get; set; }
        public Nullable<int> SOLUONG { get; set; }
        public Nullable<int> THANHTIEN { get; set; }
        public Nullable<System.DateTime> TGHOANTHANH { get; set; }
    
        public virtual HoaDon HoaDon { get; set; }
        public virtual MonAn MonAn { get; set; }
    }
}
