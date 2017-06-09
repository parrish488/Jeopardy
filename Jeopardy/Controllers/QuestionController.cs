using Jeopardy.Models;
using System;
using System.Collections.Generic;
using System.IO;
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

        public ActionResult Upload()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Upload(HttpPostedFileBase file)
        {
            if (ModelState.IsValid)
            {
                db.Database.ExecuteSqlCommand("TRUNCATE TABLE [Question]");

                string line = string.Empty;
                List<string> categories = new List<string>();
                int lineCount = 0;

                StreamReader streamReader = new StreamReader(file.InputStream);

                while (!streamReader.EndOfStream)
                {
                    line = streamReader.ReadLine();
                    string[] lineItems = line.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);

                    if (lineItems.Length == 6)
                    {
                        if (lineCount == 0)
                        {
                            foreach (string category in lineItems)
                            {
                                categories.Add(category);
                            }
                        }
                        else
                        {
                            for (int i = 0; i < 6; i++)
                            {
                                string[] questionItems = lineItems[i].Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);

                                Question question = new Question()
                                {
                                    CategoryName = categories[i],
                                    QuestionText = questionItems[0],
                                    Column = i,
                                    Row = lineCount
                                };

                                if (questionItems.Length == 2)
                                {
                                    question.ImagePath = questionItems[1];
                                }

                                db.Questions.Add(question);
                            }
                        }
                    }

                    ++lineCount;
                }

                db.SaveChanges();

                return RedirectToAction("Index","Board");
            }

            return View();
        }
    }
}