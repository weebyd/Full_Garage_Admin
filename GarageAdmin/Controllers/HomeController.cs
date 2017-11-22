using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GarageAdmin.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            //long accountId = AccountSession.AccountID;

            //if (accountId <= 0)
            //{
            //    return RedirectToAction("Login", "Account");
            //}
            //else
            //{
           
            //}

            return View();
        }
    }
}