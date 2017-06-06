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
                switch(question.Column)
                {
                    case 0:
                        board.Category1.Add(question);
                        break;
                    case 1:
                        board.Category2.Add(question);
                        break;
                    case 2:
                        board.Category3.Add(question);
                        break;
                    case 3:
                        board.Category4.Add(question);
                        break;
                    case 4:
                        board.Category5.Add(question);
                        break;
                    case 5:
                        board.Category6.Add(question);
                        break;
                }

            }

            return View(board);
        }
    }
}