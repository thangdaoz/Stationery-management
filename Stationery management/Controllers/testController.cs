using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Stationery_management.Controllers
{
    [Authorize]
    public class testController : Controller
    {
        // GET: test
        
        public ActionResult Index()
        {
            return View();
        }
    }
}