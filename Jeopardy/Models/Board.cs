using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Jeopardy.Models
{
    public class Board
    {
        public SortedSet<Question> Category1 { get; set; } = new SortedSet<Question>();
        public SortedSet<Question> Category2 { get; set; } = new SortedSet<Question>();
        public SortedSet<Question> Category3 { get; set; } = new SortedSet<Question>();
        public SortedSet<Question> Category4 { get; set; } = new SortedSet<Question>();
        public SortedSet<Question> Category5 { get; set; } = new SortedSet<Question>();
        public SortedSet<Question> Category6 { get; set; } = new SortedSet<Question>();
    }
}