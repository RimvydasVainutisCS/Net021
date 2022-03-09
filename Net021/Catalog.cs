// Catalog contains Book(s); dictionary-like collection;
// We must access any book by string key (book ISBN).

using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Net021
{
    public class Catalog : IEnumerable
    {
        private List<Book> Books;

        public Catalog()
        {
            Books = new List<Book>();
        }

        public Book this[string isbn]
        {
            get => Books.Where(book => book.ISBN == isbn).FirstOrDefault();

            // Code below is doing the same as above Linq expression.
            //{
            //    foreach (var book in Books)
            //    {
            //        if (book.ISBN == isbn)
            //        {
            //            return book;
            //        }
            //    }
            //    return null;
            //}

            //set => Books.Where(x => x.ISBN != isbn).Equals(value);
        }

        public IEnumerator GetEnumerator()
        {
            var sortedBooks = Books.OrderBy(book => book.Title);
            foreach (var book in sortedBooks)
            {
                yield return book;
            }
        }

        public void AddBook(Book book)
        {
            Books.Add(book);
        }

        public IEnumerable<Book> GetBooksByAuthor(string authorName, string lastName)
        {
            return Books.Where(book => book.HasAuthor(authorName, lastName));
        }

        public IEnumerable<Book> GetBooksByPubDateDesc()
        {
            return Books.OrderByDescending(book => book.PublishDate);
        }

        public IEnumerable<Book> GetAuthorBookCount()
        {
            return Books.
        }
    }
}
