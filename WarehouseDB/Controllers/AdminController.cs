using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model;
using BLL;
using System.Web.Razor.Text;

namespace WarehouseDB.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login(admini ad)
        {
            var text = "";
            var Flag = new AdminiBll().AdminiLogin(ad, out text);
            if (Flag != null)
            {
                System.Web.HttpContext.Current.Session.Add("adminName", ad.adminiName);
                System.Web.HttpContext.Current.Session.Add("adminPassword", ad.adminiPassword);
            }
            return Json(new
            {
                Text = text,
                Flag = Flag != null
            }
            , JsonRequestBehavior.AllowGet);
        }
    }
}