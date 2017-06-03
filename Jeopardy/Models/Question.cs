using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Jeopardy.Models
{
    public class Question : IComparable<Question>
    {
        public int Id { get; set; }
        public int Row { get; set; }
        public int Column { get; set; }
        public bool BeenVisited { get; set; } = false;
        public bool IsDailyDouble { get; set; } = false;
        public string CategoryName { get; set; } = string.Empty;
        public string QuestionText { get; set; } = string.Empty;
        public string dummy { get; set; } = string.Empty;

        public int CompareTo(Question other)
        {
            return Row.CompareTo(other.Row);
        }
    }
}