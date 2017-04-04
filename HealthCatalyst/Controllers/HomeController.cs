using HealthCatalyst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HealthCatalyst.Controllers
{
    public class HomeController : Controller
    {
        DatabaseContext db = new DatabaseContext();

        public ActionResult Index()
        {
            return View();
        }
    }
}