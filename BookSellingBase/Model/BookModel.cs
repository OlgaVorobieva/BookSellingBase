using BookSellingBase.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSellingBase
{
    public class BookModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Authors { get; set; }
        public string Discription { get; set; }
        public float Rating { get; set; }
        public int Year { get; set; }

        public BookModel(Book book)
        {
            ID = book.ID;
            Name = book.Name.Trim();
            Authors = string.Empty;
            var authors = new StringBuilder();
            foreach (var author in book.AuthorList) 
            {
                authors.Append(author.Name.Trim() + ", ");
            }
            Authors = authors.ToString();
            Discription = book.Discription.Trim();
            Rating = book.Rating;
            Year = book.Year;
        }
    }
}
