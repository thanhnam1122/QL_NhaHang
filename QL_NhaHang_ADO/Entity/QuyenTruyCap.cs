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
    
    public partial class QuyenTruyCap
    {
        public QuyenTruyCap()
        {
            this.TaiKhoans = new HashSet<TaiKhoan>();
        }
    
        public string MAQUYEN { get; set; }
        public string TENQUYEN { get; set; }
    
        public virtual ICollection<TaiKhoan> TaiKhoans { get; set; }
    }
}