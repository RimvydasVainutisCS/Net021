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
            Book bookOne = myCatalog["123-1-12-12345-1"];
            Book book = new Book("123456789012", DateTime.Now, "Book Title", new List<Author> { authorOne, authorTwo });


        }
    }
}
