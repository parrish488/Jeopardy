using Jeopardy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Jeopardy.Controllers
{
    public class BuzzInController : Controller
    {
        DatabaseContext db = new DatabaseContext();

        // GET: BuzzIn
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Control()
        {
            SortedDictionary<DateTime, string> currentValues = new SortedDictionary<DateTime, string>();

            foreach (BuzzIn buzzIn in db.BuzzIns)
            {
                currentValues.Add(buzzIn.Timestamp, buzzIn.Name);
            }

            return View(currentValues);
        }

        public JsonResult Click(string name)
        {
            BuzzIn buzzIn = new BuzzIn();
            buzzIn.Name = name;
            buzzIn.Timestamp = DateTime.Now;

            db.BuzzIns.Add(buzzIn);

            db.SaveChanges();

            return Json(string.Empty);
        }

        public JsonResult Clear()
        {
            db.Database.ExecuteSqlCommand("TRUNCATE TABLE [BuzzIn]");

            db.SaveChanges();

            return Json(string.Empty);
        }
    }
}