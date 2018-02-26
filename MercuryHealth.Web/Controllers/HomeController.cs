#region Namespaces
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.Mvc;
#endregion

namespace MercuryHealth.Web.Controllers
{
    
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            ViewBag.Message = "Web App Slot (" + WebConfigurationManager.AppSettings["MyWebSlot"] +")";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your about page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

    }

}