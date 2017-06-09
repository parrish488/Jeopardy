using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Jeopardy.Models
{
    public class DatabaseInitializer : DropCreateDatabaseIfModelChanges<DatabaseContext>
    {
        protected override void Seed(DatabaseContext context)
        {
            //var questions = new List<Question>();

            //Question question1 = new Question()
            //{
            //    Id = 1,
            //    Row = 1,
            //    Column = 1,
            //    CategoryName = "Category",
            //    QuestionText = "This is the question text."
            //};
            //Question question2 = new Question()
            //{
            //    Id = 1,
            //    Row = 2,
            //    Column = 1,
            //    CategoryName = "Category"
            //};
            //Question question3 = new Question()
            //{
            //    Id = 1,
            //    Row = 3,
            //    Column = 1,
            //    CategoryName = "Category",
            //    BeenVisited = true
            //};
            //Question question4 = new Question()
            //{
            //    Id = 1,
            //    Row = 4,
            //    Column = 1,
            //    CategoryName = "Category"
            //};
            //Question question5 = new Question()
            //{
            //    Id = 1,
            //    Row = 5,
            //    Column = 1,
            //    CategoryName = "Category"
            //};

            //questions.Add(question1);
            //questions.Add(question2);
            //questions.Add(question3);
            //questions.Add(question4);
            //questions.Add(question5);

            //context.Questions.AddRange(questions);

            //context.SaveChanges();

            //base.Seed(context);
        }
    }
}