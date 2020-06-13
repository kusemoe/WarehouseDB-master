using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model;
using BLL;
namespace WarehouseDB.Controllers
{
    public class ShipperController : Controller
    {
        // GET: Shipper
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SelectList(int limit, int page, string id)
        {
            var List = new ShippingBll().SelectList().Where(i => id == null || id == i.ShipperId).Select(i => new
            {
                i.ShippingId,
                i.ShipperId,
                i.number,
                i.ProductId,
            });
            var ListJson = new
            {
                code = 0,
                msg = "",
                count = List.Count(),
                data = List.Skip((page - 1) * limit).Take(limit).ToList()
            };
            return Json(ListJson, JsonRequestBehavior.AllowGet);
        }
        public ActionResult GetFrom(int limit, int page, int? id)
        {
            var List = new ShippingFromBll().SelectList().Select(i => new
            {
                i.ShipperId,
                ShippingTime = i.ShippingTime.ToString("yyyy-MM-dd"),
                i.lumpSum
            });
            var ListJson = new
            {
                code = 0,
                msg = "",
                count = List.Count(),
                data = List.Skip((page - 1) * limit).Take(limit).ToList()
            };
            return Json(ListJson, JsonRequestBehavior.AllowGet);
        }
    }
}