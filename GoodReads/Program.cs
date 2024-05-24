using System.ComponentModel;
using System.Text.Json.Serialization;

namespace GoodReads
{
    internal class Program
    {
        

        public static List<User> Userlist = new List<User>()
        {
            new User("Frode", 22, new List<Book>()),
            new User("Hubert", 5, new List<Book>()),
            new User("Fridtjof", 200, new List<Book>())
        };

        public static User CurrentUser;
        
        static void Main(string[] args)
        {
            logIn();
            
            while(true){
                Console.Clear();
                Console.WriteLine($"Welcome to BadReads {CurrentUser.Name}");
                Console.WriteLine($"You have read {CurrentUser.countBooks()} / {CurrentUser.BookGoal} books this year");
                Console.WriteLine($"You have read {CurrentUser.countPages()} pages this year");
                Console.WriteLine();
                Console.WriteLine("1. Add book");
                Console.WriteLine("2. View books");
                Console.WriteLine("4. Log out");
                string userInput = Console.ReadLine();
                if (userInput == "1")
                {
                    addBook();
                } else if (userInput == "2")
                {
                    showBooks();
                } else if (userInput == "3")
                {

                } else if (userInput == "4")
                {
                    logIn();
                }
            }
        }
        
        static void addBook() {
            Console.Clear();
            Console.WriteLine("What's the book called?");
            string title = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Who's the author?");
            string author = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("How many pages does your book have?");
            int pages = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Book newBook = new Book(title, author, pages);
            CurrentUser.Books.Add(newBook);
            Console.WriteLine($"{newBook.Title} by {newBook.Author} has succesfully been added");
            Console.WriteLine("Press any key to continue");
            Console.ReadKey(true);

        }

        static void logIn()
        {   Console.Clear();
            Console.WriteLine("Welcome to BadReads, who do you want to log in as?");

            for (int i = 0; i < Userlist.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {Userlist[i].Name}");
            }
            Console.WriteLine("Or press 'n' to create a new account");

            string userInput = Console.ReadLine();
            if (userInput.ToLower() == "n")
            {
                newAccount();
            }
            else
            {
                CurrentUser = Userlist[Convert.ToInt32(userInput) - 1];
            }
        }

        static void newAccount()
        {
            Console.Clear();
            Console.WriteLine("What's your name?");
            string name = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("How many books do you wish to read this year?");
            int bookGoal = Convert.ToInt32(Console.ReadLine());
            Userlist.Add(new User(name, bookGoal, new List<Book>()));
            Console.Clear();
            Console.WriteLine("User successfully added.");
            CurrentUser = Userlist[Userlist.Count - 1];
            Console.ReadKey(true);
        }

        static void showBooks()
        {
            Console.Clear();
            foreach (var book in CurrentUser.Books)
            {
                Console.WriteLine($"{book.Title} by {book.Author} ({book.Pages} pages)");
            }

            Console.ReadKey(true);
        }
    }
}
