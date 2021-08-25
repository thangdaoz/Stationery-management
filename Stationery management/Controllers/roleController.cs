using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Stationery_management.Controllers
{
    public class roleController : Controller
    {
        // GET: role
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult create()
        {
            return View();
        }
        public ActionResult edit()
        {
            return View();
        }
        public ActionResult delete()
        {
            return View();
        }
    }
}