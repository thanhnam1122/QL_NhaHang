using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using System;
using QL_NhaHang_ADO.Entity;

namespace QL_NhaHang_ADO.Controllers
{
    public class Ban2Controller : Controller
    {
        // GET: Ban2
        public ActionResult Index()
        {
            return View();
        }
        public JsonResult GetBan([DataSourceRequest] DataSourceRequest request)
        {
            using (var dbcontext = new DBNHEntities1())
            {
                var Data = dbcontext.Ban2.Select(s => new {s.BanID,s.TrangThai,s.HoatDong,s.Soghe}).ToList();

                return Json(Data.ToDataSourceResult(request));
            }
               
        }
        [AcceptVerbs("Post")]
        public ActionResult Ban2s_Create([DataSourceRequest] DataSourceRequest request, [Bind(Prefix = "models")] IEnumerable<Ban2> products)
        {
            var results = new List<Ban2>();
            using (var dbcontext = new DBNHEntities1())
            {
                if (products != null && ModelState.IsValid)
                {
                    foreach (var product in products)
                    {

                        dbcontext.Ban2.Add(product);
                        results.Add(product);
                    }
                    dbcontext.SaveChanges();
                }
            }
            return Json(results.ToDataSourceResult(request, ModelState));
        }
        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Ban2s_Update([DataSourceRequest] DataSourceRequest request, [Bind(Prefix = "models")] IEnumerable<Ban2> products)
        {
            if (products != null && ModelState.IsValid)
            {
                using (var dbcontext = new DBNHEntities1())
                {
                    foreach (var product in products)
                    {
                        var DB = dbcontext.Ban2.FirstOrDefault(s => s.BanID == product.BanID);
                        if(DB!= null)
                        {
                            DB.BanID = product.BanID;
                            DB.TrangThai = product.TrangThai;
                            DB.HoatDong = product.HoatDong;
                        }
                    }
                    dbcontext.SaveChanges();
                }
            }

            return Json(products.ToDataSourceResult(request, ModelState));
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Ban2s_Destroy([DataSourceRequest] DataSourceRequest request, [Bind(Prefix = "models")] IEnumerable<Ban2> products)
        {
            if (products.Any())
            {
                using (var dbcontext = new DBNHEntities1())
                {
                    foreach (var product in products)
                    {
                        var DB = dbcontext.Ban2.FirstOrDefault(s => s.BanID == product.BanID);
                        if(DB!= null)
                        {
                            dbcontext.Ban2.Remove(DB);
                        }
                    }
                    dbcontext.SaveChanges();
                }
            }
            return Json(products.ToDataSourceResult(request, ModelState));
        }
    }
}