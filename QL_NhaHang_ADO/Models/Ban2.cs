using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QL_NhaHang_ADO.Models
{
    public class Ban2
    {
        public int BanID { get; set; }
        public string TrangThai { get; set; }
        public string Soghe { get; set; }
        public Nullable<bool> HoatDong { get; set; }
    }
}