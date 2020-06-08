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

            AdminiBll admini = new AdminiBll();
            var Flag = admini.AdminiLogin(ad);
            if (Flag == null)
                return RedirectToAction("Index");
            else
            {
                HttpContext.Session[ad.adminiName] =1;
                HttpContext.Session[ad.adminiPassword] =2;
                return RedirectToRoute(new { controller = "Home", action = "Index" });
            }
        }
    }
}