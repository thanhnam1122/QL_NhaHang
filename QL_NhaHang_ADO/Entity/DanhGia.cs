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
    
    public partial class DanhGia
    {
        public string MADANHGIA { get; set; }
        public string MAHOADON { get; set; }
        public string DANHGIA1 { get; set; }
    
        public virtual HoaDon HoaDon { get; set; }
    }
}
