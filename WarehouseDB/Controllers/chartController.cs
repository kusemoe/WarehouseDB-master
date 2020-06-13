using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL;
using Model;
namespace WarehouseDB.Controllers
{
    public class ChartController : Controller
    {
        // GET: chart
        public ActionResult Index()
        {
            _ = System.Web.HttpContext.Current.Session;
            return View();
        }
        public ActionResult GetData()
        {
            var list = new BillBll().Select();
            var data = new
            {
                type = list.Select(i => (i.type)),
                money = list.Select(i => (i.money))
            };
            return Json(data, JsonRequestBehavior.AllowGet);
        }
    }

}