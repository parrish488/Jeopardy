using Jeopardy.Models;
using System.Web.Mvc;

namespace Jeopardy.Controllers
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