using System;
using System.Collections.Generic;

namespace Net021
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Author authorOne = new Author("Tom", "Tomlastname");
            Author authorTwo = new Author("Sarah", "Sarahlastname");

            Catalog myCatalog = new Catalog();
            //Book bookOne = myCatalog["123-1-12-12345-1"];
            Book book1 = new Book("1234567890123", DateTime.Now, "Book Title", new List<Author> { authorOne, authorTwo });
            Book book2 = new Book("1234567890134", null, "Book Title2", new List<Author> { authorOne, authorTwo });

            var asdf = book1 == book2;


            myCatalog.AddBook(book1);
            myCatalog.AddBook(book2);


            var bookList = myCatalog.GetBooksByPubDateDesc();

            foreach (var book in bookList)
            {
                Console.WriteLine(book.ISBN);
            }
        }
    }
}
