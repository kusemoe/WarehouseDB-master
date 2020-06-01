using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model;
using BLL;
using Microsoft.Ajax.Utilities;
using System.Web.Services.Description;
using System.Security.Cryptography;
using System.Web.Query.Dynamic;

namespace WarehouseDB.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult product(int page, int limit)
        {
            var bll = new ProductBll();
            var list = bll.SelectProduct().Select(pro => new
            {
                pro.Barcode,
                pro.Bill,
                pro.money,
                pro.ProductName,
                pro.ProductId,
                pro.Remarks,
                pro.type.typeName
            });
            var ListJson = new
            {
                code = 0,
                msg = "",
                count = list.Count(),
                data = list.Skip((page - 1) * limit).Take(limit).ToList()
            };
            return Json(ListJson, JsonRequestBehavior.AllowGet);
        }
        public ActionResult staff(int page, int limit)
        {
            var bll = new staffBll();
            var List = bll.SelectList();
            var ListJson = new
            {
                code = 0,
                msg = "",
                count = List.Count(),
                data = List.Skip((page - 1) * limit).Take(limit).ToList()
            };
            return Json(ListJson, JsonRequestBehavior.AllowGet);
        }
        public ActionResult Bill(int page, int limit)
        {
            var bll = new BillBll();
            var List = bll.SelectList();
            var ListJson = new
            {
                code = 0,
                msg = "",
                count = List.Count(),
                data = List.Skip((page - 1) * limit).Take(limit).ToList()
            };
            return Json(ListJson, JsonRequestBehavior.AllowGet);
        }
        public ActionResult Purchase(int page, int limit)
        {
            var bll = new PurchaseBll();
            var List = bll.SelectList();
            var ListJson = new
            {
                code = 0,
                msg = "",
                count = List.Count(),
                data = List.Skip((page - 1) * limit).Take(limit).ToList()
            };
            return Json(ListJson, JsonRequestBehavior.AllowGet);
        }
        public ActionResult Shipping(int page, int limit)
        {
            var bll = new ShippingBll();
            var List = bll.SelectList();
            var ListJson = new
            {
                code = 0,
                msg = "",
                count = List.Count(),
                data = List.Skip((page - 1) * limit).Take(limit).ToList()
            };
            return Json(ListJson, JsonRequestBehavior.AllowGet);
        }
        public ActionResult client(int page, int limit)
        {
            var bll = new clientBll();
            var List = bll.SelectList();
            var ListJson = new
            {
                code = 0,
                msg = "",
                count = List.Count(),
                data = List.Skip((page - 1) * limit).Take(limit).ToList()
            };
            return Json(ListJson, JsonRequestBehavior.AllowGet);
        }
        public ActionResult admini(int page, int limit)
        {
            var bll = new AdminiBll();
            var List = bll.SelectList();
            var ListJson = new
            {
                code = 0,
                msg = "",
                count = List.Count(),
                data = List.Skip((page - 1) * limit).Take(limit).ToList()
            };
            return Json(ListJson, JsonRequestBehavior.AllowGet);
        }
        public ActionResult supplier(int page, int limit)
        {
            var bll = new supplierBll();
            var List = bll.SelectList();
            var ListJson = new
            {
                code = 0,
                msg = "",
                count = List.Count(),
                data = List.Skip((page - 1) * limit).Take(limit).ToList()
            };
            return Json(ListJson, JsonRequestBehavior.AllowGet);
        }
        public ActionResult type(int page, int limit)
        {
            var bll = new TypeBll();
            var List = bll.SelectList();
            var ListJson = new
            {
                code = 0,
                msg = "",
                count = List.Count(),
                data = List.Skip((page - 1) * limit).Take(limit).ToList()
            };
            return Json(ListJson, JsonRequestBehavior.AllowGet);
        }
        public ActionResult Order(int page, int limit)
        {
            OrderBll bll = new OrderBll();
            var List = bll.SelectList();
            var ListJson = new
            {
                code = 0,
                msg = "",
                count = List.Count(),
                data = List.Skip((page - 1) * limit).Take(limit).ToList()
            };
            return Json(ListJson, JsonRequestBehavior.AllowGet);
        }
        public ActionResult department(int page, int limit)
        {
            var bll = new departmentBll();
            var List = bll.SelectList();
            var ListJson = new
            {
                code = 0,
                msg = "",
                count = List.Count(),
                data = List.Skip((page - 1) * limit).Take(limit).ToList()
            };
            return Json(ListJson, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Test(string t, int id)
        {
            switch (t)
            {
                case "type":
                    new TypeBll().Remove(new type { typeID = id });
                    break;
                case "Bill":
                    new BillBll().Remove(new Bill { BillId = id });
                    break;
                case "staff":
                    new staffBll().Remove(new staff { StaffId = id });
                    break;
                case "Order":
                    new OrderBll().Remove(new Order { OrderId = id });
                    break;
                case "client":
                    new clientBll().Remove(new client { ClientId = id });
                    break;
                case "admini":
                    new AdminiBll().Remove(new admini { adminiId = id });
                    break;
                case "product":
                    new ProductBll().Remove(new product { ProductId = id });
                    break;
                case "supplier":
                    new supplierBll().Remove(new supplier { supplierId = id });
                    break;
                case "Purchase":
                    new PurchaseBll().Remove(new Purchase { PurchaseId = id });
                    break;
                case "Shipping":
                    new ShippingBll().Remove(new Shipping { ShippingId = id });
                    break;
                case "department":
                    new departmentBll().Remove(new department { departmentId = id });
                    break;
            }
            return Content("1");
        }

    }

}