using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodReads
{
    internal class User
    {
        public string Name;
        public int BookGoal;
        public List<Book> Books;

        public User(string name, int bookgoal, List<Book> books)
        {
            Name = name;
            BookGoal = bookgoal;
            Books = books;
        }

        public int countBooks()
        {
            int count = 0;
            foreach (var book in Books)
            {
                count++;
            }

            return count;
        }

        public int countPages()
        {
            int count = 0;
            foreach (var book in Books)
            {
                count += book.getPages();
            }

            return count;
        }
    }
}
