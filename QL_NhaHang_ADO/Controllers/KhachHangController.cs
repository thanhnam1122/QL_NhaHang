﻿using QL_NhaHang_ADO.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QL_NhaHang_ADO.Controllers
{
    public class KhachHangController : Controller
    {
        private XuLyThongTinKhachHang khachhangRepo = new XuLyThongTinKhachHang();
        private static string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["connect1"].ConnectionString;
        // GET: KhachHang
        public ActionResult Profile()
        {
            // Kiểm tra đăng nhập
            ViewBag.Mail = Session["Mail"];
            ViewBag.HoTen = Session["HoTen"];
            ViewBag.Avatar = Session["Avatar"];
            ViewBag.MaKH = Session["MaKH"];
            ViewBag.NgaySinh = Session["NgaySinh"];
            ViewBag.SoDT = Session["SoDT"];
            ViewBag.DiemThanhVien = Session["DiemThanhVien"];

            return View();
        }
        public ActionResult NhapThongTinKhachHang()
        {
            return View();
        }
        [HttpPost]
        public ActionResult NhapThongTinKhachHang(KhachHang model)
        {
            if (ModelState.IsValid)
            {
                XuLyThongTinKhachHang objKH = new XuLyThongTinKhachHang();
                List<KhachHang> listKH = objKH.LayThongTinKhachHang();

                bool isValidUser = true;

              
                if (isValidUser == true)
                {
                    bool isRegistered = ThongTinKhachHang(model);
                    if (isRegistered)
                    {
                        TempData["SignSuccess"] = true;
                        return RedirectToAction("DangNhap","Account");
                    }
                    else
                    {
                        return View(model);
                    }
                }
            }
            else
            {

                TempData["ErrorMessage"] = true;

            }
            return View(model);

        }
        public string GenerateMaKHACHANG()
        {
            string prefix = "KH";
            int nextNumber = GetNextNumberFromDatabase(); // Hàm để lấy số tiếp theo từ CSDL
            string maTaiKhoan = prefix + nextNumber.ToString("D4"); // Format thành 'TK0001'

            return maTaiKhoan;
        }
        public int GetNextNumberFromDatabase()
        {
            int nextNumber = 1; // Giá trị mặc định nếu không có dữ liệu trong bảng
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["connect1"].ConnectionString; // Chuỗi kết nối tới Oracle

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // Truy vấn số thứ tự lớn nhất hiện có
                string query = "SELECT MAX(CAST(SUBSTRING(MaKH, 3, LEN(MaKH) - 2) AS INT)) AS MaxValue FROM KhachHang;";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    var result = cmd.ExecuteScalar();

                    if (result != DBNull.Value && result != null)
                    {
                        nextNumber = Convert.ToInt32(result) + 1; // Số tiếp theo
                    }
                }
            }

            return nextNumber;
        }
        public bool ThongTinKhachHang(KhachHang khachHang)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
               

                // Truy vấn SQL để thêm tài khoản với token xác thực
                string query = @"
INSERT INTO KhachHang (MaKH, MaTaiKhoan, HOTEN, NGAYSINH, SODT, DIEMTHANHVIEN, AVATAR) 
VALUES (@MaKH, @MaTaiKhoan, @HOTEN, @NGAYSINH, @SODT, @DIEMTHANHVIEN , @AVATAR)";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.Add(new SqlParameter("@MaKH", GenerateMaKHACHANG()));
                cmd.Parameters.Add(new SqlParameter("@MaTaiKhoan", Session["MaTaiKhoan"]));
                cmd.Parameters.Add(new SqlParameter("@HOTEN", khachHang.HoTen));
                cmd.Parameters.Add(new SqlParameter("@NGAYSINH", khachHang.NgaySinh));
                cmd.Parameters.Add(new SqlParameter("@SODT", khachHang.SoDT));
                cmd.Parameters.Add(new SqlParameter("@DIEMTHANHVIEN",khachHang.DiemThanhVien));
                cmd.Parameters.Add(new SqlParameter("@AVATAR", khachHang.Avatar));

                conn.Open();
                int result = cmd.ExecuteNonQuery();
                conn.Close();
                return result > 0;
            }
        }
    }
}