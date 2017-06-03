using Jeopardy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Jeopardy.Controllers
{
    public class BoardController : Controller
    {
        DatabaseContext db = new DatabaseContext();

        // GET: Board
        public ActionResult Index()
        {
            Board board = new Board();

            foreach (Question question in db.Questions)
            {
                board.Category1.Add(question);
            }

            foreach (Question question in db.Questions)
            {
                board.Category2.Add(question);
            }

            foreach (Question question in db.Questions)
            {
                board.Category3.Add(question);
            }

            foreach (Question question in db.Questions)
            {
                board.Category4.Add(question);
            }

            foreach (Question question in db.Questions)
            {
                board.Category5.Add(question);
            }

            foreach (Question question in db.Questions)
            {
                board.Category6.Add(question);
            }

            return View(board);
        }
    }
}