using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodReads
{
    internal class Book
    {
        public string Title;
        public string Author;
        public int Pages;


        public Book(string title, string author, int pages)
        {
            Title = title;
            Author = author;
            Pages = pages;
        }
    }
}
