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
    
    public partial class Ban2
    {
        public Ban2()
        {
            this.DatBans = new HashSet<DatBan>();
        }
    
        public int BanID { get; set; }
        public string TrangThai { get; set; }
        public string Soghe { get; set; }
        public Nullable<bool> HoatDong { get; set; }
    
        public virtual ICollection<DatBan> DatBans { get; set; }
    }
}
