using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSellingBase.Core
{
    public class Book
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public List<Author> AuthorList { get; set; }
        public string Discription { get; set; }
        public float Rating { get; set; }
        public int Year { get; set; }
        public int CategoryID { get; set; }
    }
}
