using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model;
using BLL;
using Microsoft.Ajax.Utilities;
using System.Web.Services.Description;

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
            ProductBll bll = new ProductBll();
            var list = bll.SelectProduct();
            for (int i = 0; i < 100; i++)
            {
                var pro = new product
                {
                    ProductId = i,
                    Barcode = "4",
                    ProductName = "3",
                    money = 5,
                    typeId = 6,
                    Remarks = "2"
                };
                list.Add(pro);
            }
            var ListJson = new
            {
                code = 0,
                msg = "",
                count = list.Count,
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




    }

}