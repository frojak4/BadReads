using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodReads
{
    internal class Book
    {
        private string Title;
        private string Author;
        private int Pages;


        public Book(string title, string author, int pages)
        {
            Title = title;
            Author = author;
            Pages = pages;
        }

        public string getTitle()
        {
            return Title;
        }

        public string getAuthor()
        {
            return Author;
        }

        public int getPages()
        {
            return Pages;
        }
    }
}
