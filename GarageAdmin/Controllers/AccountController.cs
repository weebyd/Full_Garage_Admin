﻿using System.Web.Mvc;

namespace GarageAdmin.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Login()
        {
            return View();
        }
    }
}