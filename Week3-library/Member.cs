using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Book
    {
        private string title; // private variable
        private string author;// private variable
        private string isbn; // private variable
        

        // Title property allows access
        // to the title private variable
        public string Title
        {
            get { return title; }  // get method
            set { title = value; } // set method
        }
        public string Author
        {
            get { return author; }
            set { author = value; }
        }
        public string ISBN
        {
            get { return isbn; }
            set { isbn = value; }
        }

        // Constructor to add a new book
        public Book(string bookTitle, string bookAuthor, string bookISBN)
        {
            this.Title = bookTitle;
            this.Author = bookAuthor;
            this.ISBN = bookISBN;
        }

        // Method to display information about a book
        public void DisplayInfo()
        {
            Console.WriteLine($"Book title: {Title}");
            Console.WriteLine($"Book Author: {Author}");
            Console.WriteLine($"Book ISBN: {ISBN}");
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Book book = new Book();

            // This information is for one book in our library
            book.Title = "C# for beginners";
            book.Author = "BillGates";
            book.ISBN = "12345678";

            // This is another book object.
            // Note that the object name is 'book1' and not 'book'
            Book book1 = new Book();
            book1.Title = "C# Methods and classes";
            book1.Author = "Microsoft";
            book1.ISBN = "55667778";

            // Output book information to the console
            book.DisplayInfo();
            book1.DisplayInfo();
        }
    }
}
