using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace QL_NhaHang_ADO.Models
{
    public class DatBan
    {
        public int DatBanID { get; set; }
        public Nullable<int> BanID { get; set; }
        public Nullable<int> SoNguoi { get; set; }
        public Nullable<System.DateTime> ThoiGianDat { get; set; }
        public string MAKH { get; set; }
        public string TrangThai { get; set; }
        [UIHint("Ban2Editor")]
        public virtual Ban2 Ban2 { get; set; }
    }
}