using Jeopardy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Jeopardy.Controllers
{
    public class QuestionController : Controller
    {
        DatabaseContext db = new DatabaseContext();

        public ActionResult Show(int id)
        {
            var questions = (from q in db.Questions
                                 where q.Id == id
                                 select q);

            Question question = questions.First();
            question.BeenVisited = true;

            db.Entry(question).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();

            return View(question);
        }
    }
}