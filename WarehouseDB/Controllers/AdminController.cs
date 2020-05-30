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
                return JavaScript("");
            else
                return JavaScript("");
        }
    }
}