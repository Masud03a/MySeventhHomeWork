
using System;

namespace Task_2
{
    class Program
    {
        class Book
        {
            private Title _bookTitle;
            private Author _bookAuthor;
            private Base _bookBase;
            
            public Book(string _title, string _author, string _base)
            {
                _bookTitle = new Title();
                _bookAuthor = new Author();
                _bookBase = new Base();
                _bookTitle.titleStr = _title;
                _bookAuthor.authorStr = _author;
                _bookBase.baseStr = _base;
            }

            public void ShowInfo()
            {
                _bookTitle.Show();
                _bookAuthor.Show();
                _bookBase.Show();
            }

            public void ShowTitle()
            {
                _bookTitle.Show();
            }

            public void ShowAuthor()
            {
                _bookAuthor.Show();
            }

            public void ShowBase()
            {
                _bookBase.Show();
            }
        }

        class Title
        {
            public string titleStr { get; set; }
            public void Show()
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Title: " + this.titleStr);
            }
        }

        class Author
        {
            public string authorStr { get; set; }
            public void Show()
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Author: " + this.authorStr);
            }
        }

        class Base
        {
            public string baseStr { get; set; }
            public void Show()
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Grey;
                Console.WriteLine("Base: " + this.baseStr);
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Input Author: ");
            string author = Console.ReadLine();
            Console.Write("Input Title: ");
            string title = Console.ReadLine();
            Console.Write("Input Base: ");
            string base = Console.ReadLine();

            Book book = new Book(title, author, base);
            book.ShowInfo();
        }
    }
}
