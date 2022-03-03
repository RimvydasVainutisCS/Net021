// Catalog contains Book(s); dictionary-like collection;
// We must access any book by string key (book ISBN).

using System.Collections.Generic;
using System.Linq;

namespace Net021
{
    public class Catalog
    {
        private List<Book> Books { get; set; }

        public Book this[string isbn]
        {
            get => Books.Where(x => x.ISBN == isbn).FirstOrDefault();

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


            set
            {

            }
        }
    }
}
