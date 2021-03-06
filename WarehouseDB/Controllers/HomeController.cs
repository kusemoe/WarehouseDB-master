﻿using BLL;
using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web.Mvc;
using System.Web.Query.Dynamic;

namespace WarehouseDB.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var name = System.Web.HttpContext.Current.Session["adminName"];
            if (name != null)
                return View();
            else
                return RedirectToRoute(new { controller = "Admin", action = "Index" });
        }

        #region 数据查询
        public ActionResult Type(int page, int limit, type t)
        {
            var bll = new TypeBll();
            var List = bll.SelectList()
                .Where(i => isTrue(i.typeName, t.typeName))
                .Select(i => new
                {
                    i.typeID,
                    i.typeName
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
        public ActionResult Bill(int page, int limit, Bill t)
        {
            var bll = new BillBll();
            var List = bll.SelectList()
                .Where(i =>
                    IsTrue(i.ProductId, t.ProductId)
                    && IsTrue(i.BillNum, t.BillNum)
                    && isTrue(i.BillType, t.BillType)
                    && isTrue(i.BillTime.ToString(), t.BillTime)
                )
                .Select(i => new
                {
                    i.BillId,
                    ProductId = i.product.ProductName,
                    i.BillNum,
                    i.BillType,
                    BillTime = i.BillTime.ToString(),
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
        public ActionResult Order(int page, int limit, Order t)
        {
            OrderBll bll = new OrderBll();
            var List = bll.SelectList()
                .Where(i =>
                    isTrue(i.BarCode, t.BarCode)
                    && IsTrue(i.OrderTime, t.OrderTime)
                    && isTrue(i.address, t.address)
                    && isTrue(i.Remarks, t.Remarks)
                )
                .Select(i => new
                {
                    i.BarCode,
                    i.address,
                    i.OrderId,
                    OrderTime = i.OrderTime.ToString(),
                    i.Remarks

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
        public ActionResult Staff(int page, int limit, staff t, string sex)
        {
            var bll = new staffBll();
            var List = bll.SelectList()
                .Where(i =>
                    IsTrue(i.EntryTime, t.EntryTime)
                    && isTrue(i.StaffName, t.StaffName)
                    && IsTrue(i.departmentType, t.departmentType)
                    && isTrue(sex, sex)
                )
                .Select(i => new
                {
                    i.StaffId,
                    EntryTime = i.EntryTime.ToString(),
                    i.StaffName,
                    StaffSex = i.StaffSex ? "男" : "女",
                    departmentId = i.department.departmentName
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
        public ActionResult Client(int page, int limit, client t)
        {
            var bll = new clientBll();
            var List = bll.SelectList()
                .Where(i =>
                    isTrue(i.ClientName, t.ClientName)
                    && isTrue(i.Emli, t.Emli)
                    && isTrue(i.Phone, t.Phone)
                    && isTrue(i.Address, t.Address)
                )
                .Select(i =>
            new
            {
                i.ClientId,
                i.ClientName,
                i.Address,
                i.Emli,
                i.Phone
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
        public ActionResult Admini(int page, int limit, admini t)
        {
            var bll = new AdminiBll();
            var List = bll.SelectList()
                .Where(i =>
                    isTrue(i.adminiName, t.adminiName)
                    && isTrue(i.adminiPassword, t.adminiPassword)
                );
            var ListJson = new
            {
                code = 0,
                msg = "",
                count = List.Count(),
                data = List.Skip((page - 1) * limit).Take(limit).ToList()
            };
            return Json(ListJson, JsonRequestBehavior.AllowGet);
        }
        public ActionResult Product(int page, int limit, product t)
        {
            var bll = new ProductBll();
            var list = bll.SelectProduct()
                .Where(i =>
                    isTrue(i.Barcode, t.Barcode)
                    && isTrue(i.ProductName, t.ProductName)
                    && IsTrue(i.money, t.money)
                    && IsTrue(i.typeId, t.typeId)
                    && isTrue(i.Remarks, t.Remarks))
                .Select(pro => new
                {
                    pro.Barcode,
                    pro.money,
                    pro.ProductName,
                    pro.ProductId,
                    pro.Remarks,
                    typeId = pro.type.typeName
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
        public ActionResult Shipping(int page, int limit, Shipping t)
        {
            var bll = new ShippingBll();
            var List = bll.SelectList()
                .Where(i => IsTrue(i.number, t.number)
                    && IsTrue(i.ProductId, t.ProductId)
                )
                .Select(i => new
                {
                    i.ShippingId,
                    i.number,
                    i.ShipperId,
                    ProductId = i.product.ProductName,
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
        public ActionResult Supplier(int page, int limit, supplier t)
        {
            var bll = new supplierBll();
            var List = bll.SelectList()
                .Where(i =>
                    isTrue(i.supplierName, t.supplierName)
                    && isTrue(i.Address, t.Address)
                    && isTrue(i.phone, t.phone)
                    && isTrue(i.principal, t.principal)
                    && isTrue(i.Emli, t.Emli)
                )
                .Select(i =>
                new
                {
                    i.supplierId,
                    i.supplierName,
                    i.Address,
                    i.Emli,
                    i.phone,
                    i.principal
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
        public ActionResult Purchase(int page, int limit, Purchase t)
        {
            var bll = new PurchaseBll();
            var List = bll.SelectList()
                .Where(i =>
                    IsTrue(i.ProductId, t.ProductId)
                    && IsTrue(i.supplierId, t.supplierId)
                    && IsTrue(i.number, t.number)
                    && IsTrue(i.status, t.status)
                    && IsTrue(i.PurchaseTime, t.PurchaseTime)
                )
                .Select(i =>
            new
            {
                i.PurchaseId,
                supplierId = i.supplier.supplierName,
                PurchaseTime = i.PurchaseTime.ToString(),
                i.number,
                status = StateGet(i.status),
                ProductId = i.product.ProductName
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
        public ActionResult Department(int page, int limit, department t)
        {
            var bll = new departmentBll();
            var List = bll.SelectList()
                .Where(i => isTrue(i.departmentName, t.departmentName))
                .Select(i => new
                {
                    i.departmentId,
                    i.departmentName
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
        public ActionResult Depot(int page, int limit)
        {
            var bll = new DepotBll();
            var List = bll.SelectList().Select(i => new
            {
                i.Id,
                ProductId = i.product.ProductName,
                i.stock
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
        #endregion
        #region 数据删除
        public ActionResult Test(string t, int id)
        {
            string error = "1";
            switch (t)
            {
                case "Type":
                    new TypeBll().Remove(new type { typeID = id }, out error);
                    break;
                case "Bill":
                    new BillBll().Remove(new Bill { BillId = id });
                    break;
                case "Staff":
                    new staffBll().Remove(new staff { StaffId = id });
                    break;
                case "Order":
                    new OrderBll().Remove(new Order { OrderId = id });
                    break;
                case "Client":
                    new clientBll().Remove(new client { ClientId = id }, out error);
                    break;
                case "Admini":
                    new AdminiBll().Remove(new admini { adminiId = id });
                    break;
                case "Product":
                    new ProductBll().Remove(new product { ProductId = id }, out error);
                    break;
                case "Supplier":
                    new supplierBll().Remove(new supplier { supplierId = id }, out error);
                    break;
                case "Purchase":
                    new PurchaseBll().Remove(new Purchase { PurchaseId = id });
                    break;
                case "Shipping":
                    new ShippingBll().Remove(new Shipping { ShippingId = id });
                    break;
                case "Department":
                    new departmentBll().Remove(new department { departmentId = id });
                    break;
                case "Depot":
                    new DepotBll().Remove(new depot { Id = id });
                    break;
            }
            return Content(error);
        }
        #endregion
        #region 下拉框查询
        public ActionResult SelectDepartment()
        {
            var list = new departmentBll().SelectList().Select(i => new { id = i.departmentId, name = i.departmentName });
            return Json(list, JsonRequestBehavior.AllowGet);
        }
        //State
        public ActionResult SelectState()
        {
            List<object> list = new List<object> {
                new {id=1, name="待审核"},
                new {id=2, name="审核成功"},
                new {id=3, name="审核失败"}
            };
            return Json(list, JsonRequestBehavior.AllowGet);
        }
        //Client
        public ActionResult SelectClient()
        {
            var list = new clientBll().SelectList().Select(i => new { id = i.ClientId, name = i.ClientName });
            return Json(list, JsonRequestBehavior.AllowGet);
        }
        //Supplier
        public ActionResult SelectSupplier()
        {
            var list = new supplierBll().SelectList().Select(i => new { id = i.supplierId, name = i.supplierName });
            return Json(list, JsonRequestBehavior.AllowGet);
        }
        //type
        public ActionResult SelectType()
        {
            var list = new TypeBll().SelectList().Select(i => new { id = i.typeID, name = i.typeName });
            return Json(list, JsonRequestBehavior.AllowGet);
        }
        public ActionResult SelectProduct()
        {
            var list = new ProductBll().SelectProduct().Select(i => new { id = i.ProductId, name = i.ProductName });
            return Json(list, JsonRequestBehavior.AllowGet);
        }
        public ActionResult SelectDepotNum()
        {
            var list = new DepotBll().SelectList().Select(i => new { id = i.ProductId, name = i.product.ProductName });
            return Json(list, JsonRequestBehavior.AllowGet);
        }
        public ActionResult GetSelectDepot(int id)
        {
            var MaxNum = new DepotBll().SelectList().Where(i => i.ProductId == id).First().stock;
            return Content(MaxNum.ToString());
        }

        #endregion
        #region 添加数据

        public ActionResult AddType(type AddData)
        {
            var Flag = new TypeBll().Add(AddData) != 0;
            return Content(Flag.ToString());
        }
        public ActionResult AddBill(Bill AddData)
        {
            var Flag = new BillBll().Add(AddData) != 0;
            return Content(Flag.ToString());
        }
        public ActionResult AddClient(client AddData)
        {
            var Flag = new clientBll().Add(AddData) != 0;
            return Content(Flag.ToString());
        }
        public ActionResult AddDepartment(department AddData)
        {
            var Flag = new departmentBll().Add(AddData) != 0;
            return Content(Flag.ToString());
        }
        public ActionResult AddOrder(Order AddData)
        {
            var Flag = new OrderBll().Add(AddData) != 0;
            return Content(Flag.ToString());
        }
        public ActionResult AddProduct(product AddData)
        {
            var Flag = new ProductBll().Add(AddData) != 0;
            return Content(Flag.ToString());
        }
        //Purchase Shipping
        public ActionResult AddPurchase(Purchase AddData)
        {
            //ProductId: "1"
            //supplierId: "1"
            var Flag = new PurchaseBll().Add(AddData) != 0;
            if (Flag)
            {
                new DepotBll().Update(AddData.ProductId, AddData.number, true);
            }
            return Content(Flag.ToString());
        }
        public ActionResult AddShipping(Shipping AddData)
        {
            var Flag = new ShippingBll().Add(AddData) != 0;
            if (Flag)
            {
                new DepotBll().Update(AddData.ProductId, AddData.number, false);
            }
            return Content(Flag.ToString());
        }
        public ActionResult AddStaff(staff AddData, string departmentName)
        {
            AddData.departmentType = Convert.ToInt32(departmentName);
            var Flag = new staffBll().Add(AddData) != 0;
            return Content(Flag.ToString());
        }
        public ActionResult AddSupplier(supplier AddData)
        {
            var Flag = new supplierBll().Add(AddData) != 0;
            return Content(Flag.ToString());
        }
        public ActionResult AddAdmini(admini AddData)
        {
            var Flag = new AdminiBll().Add(AddData) != 0;
            return Content(Flag.ToString());
        }
        public ActionResult AddDepot(depot AddData)
        {
            var Flag = new DepotBll().Add(AddData) != 0;
            return Content(Flag.ToString());
        }
        #endregion
        #region 数据验证
        public bool isTrue(string a, string b)
        {
            if (string.IsNullOrEmpty(b))
                return true;
            return a.IndexOf(b) != -1;
        }
        public bool IsTrue(DateTime a, DateTime b)
        {
            if (b == null || b.Year == 1)
                return true;
            return a.Equals(b);
        }
        public bool IsTrue(int a, int b)
        {
            if (b == 0)
                return true;
            return a == b;
        }
        private bool IsTrue(decimal a, decimal b)
        {
            if (b == 0)
                return true;
            return a == b;
        }
        #endregion
        public string StateGet(int n)
        {
            switch (n)
            {
                case 1:
                    return "待审核";
                case 2:
                    return "审核成功";
                case 3:
                    return "审核失败";
            }
            return null;
        }
    }
}