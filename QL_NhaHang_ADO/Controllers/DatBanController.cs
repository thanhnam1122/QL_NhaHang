using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using System;
using QL_NhaHang_ADO.Entity;
using System.Data.Entity;

namespace QL_NhaHang_ADO.Controllers
{
    public class DatBan2Controller : Controller
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
                
                var Data = dbcontext.DatBans.Select(s => new {s.DatBanID,s.BanID,s.MAKH,s.TrangThai,s.SoNguoi,s.ThoiGianDat}).ToList();
                ViewData["ban2"] = dbcontext.Ban2.Select(s => new {s.BanID,s.TrangThai});
                return Json(Data.ToDataSourceResult(request));
            }
               
        }
        [AcceptVerbs("Post")]
        public ActionResult DatBans_Create([DataSourceRequest] DataSourceRequest request, [Bind(Prefix = "models")] IEnumerable<DatBan> products)
        {
            var results = new List<DatBan>();
            using (var dbcontext = new DBNHEntities1())
            {
                if (products != null && ModelState.IsValid)
                {
                    foreach (var product in products)
                    {
                        
                            dbcontext.DatBans.Add(product);
                            results.Add(product);
                    }
                    dbcontext.SaveChanges();
                }
            }
            return Json(results.ToDataSourceResult(request, ModelState));
        }
        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult DatBans_Update([DataSourceRequest] DataSourceRequest request, [Bind(Prefix = "models")] IEnumerable<DatBan> products)
        {
            if (products != null && ModelState.IsValid)
            {
                using (var dbcontext = new DBNHEntities1())
                {
                    foreach (var product in products)
                    {
                        var DB = dbcontext.DatBans.FirstOrDefault(s => s.DatBanID == product.DatBanID);
                        if(DB!= null)
                        {
                            DB.ThoiGianDat = product.ThoiGianDat;
                            DB.BanID = product.BanID;
                            DB.SoNguoi = product.SoNguoi;
                            DB.TrangThai = product.TrangThai;
                        }
                    }
                    dbcontext.SaveChanges();
                }
            }

            return Json(products.ToDataSourceResult(request, ModelState));
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult DatBans_Destroy([DataSourceRequest] DataSourceRequest request, [Bind(Prefix = "models")] IEnumerable<DatBan> products)
        {
            if (products.Any())
            {
                using (var dbcontext = new DBNHEntities1())
                {
                    foreach (var product in products)
                    {
                        var DB = dbcontext.DatBans.FirstOrDefault(s => s.DatBanID == product.DatBanID);
                        if(DB!= null)
                        {
                            dbcontext.DatBans.Remove(DB);
                        }
                    }
                    dbcontext.SaveChanges();
                }
            }
            return Json(products.ToDataSourceResult(request, ModelState));
        }
    }
}