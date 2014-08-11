using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.WindowsAzure.ServiceRuntime;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            ViewBag.id = RoleEnvironment.CurrentRoleInstance.Id;
            Session["Test"] = "Have Value";
            ViewData["Test"] = "Have Value";
            ViewBag.Test = "Have Value";
            TempData["Test"] = "Have Value";
            return View();
        }

        public ActionResult Index2()
        {
            ViewBag.id = RoleEnvironment.CurrentRoleInstance.Id;
            return View();
        }
    }
}
