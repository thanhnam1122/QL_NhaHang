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
    
    public partial class HoaDon
    {
        public HoaDon()
        {
            this.ChiTietHoaDons = new HashSet<ChiTietHoaDon>();
            this.DanhGias = new HashSet<DanhGia>();
        }
    
        public string MAHOADON { get; set; }
        public string MABAN { get; set; }
        public string MAKH { get; set; }
        public string MANV { get; set; }
        public string MAGIAMGIA { get; set; }
        public Nullable<System.DateTime> NGAYLAP { get; set; }
        public Nullable<int> TONGTIEN { get; set; }
        public string HINHTHUC { get; set; }
    
        public virtual Ban Ban { get; set; }
        public virtual ICollection<ChiTietHoaDon> ChiTietHoaDons { get; set; }
        public virtual ICollection<DanhGia> DanhGias { get; set; }
        public virtual GiamGia GiamGia { get; set; }
        public virtual KhachHang KhachHang { get; set; }
        public virtual NhanVien NhanVien { get; set; }
    }
}