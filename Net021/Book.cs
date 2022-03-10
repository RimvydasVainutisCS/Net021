// Book(s) properties:
// ISBN; string; Forms: "XXX-X-XX-XXXXXX-X" or "XXXXXXXXXXXXX" where X is a digit 0..9.
// Title of the book; non empty string, limited to 1000 chars.
// Publication date of the book; possibly empty/not set;
// Colletion of book Author(s); possibly empty;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Net021
{
    public class Book : IEquatable<Book>
    {
        // Variable
        private readonly string _title;
        private const int TITLE_LENGHT = 1000;
        private readonly Regex _regex1 = new Regex(@"\d{3}\-\d{1}\-\d{2}\-\d{6}\-\d{1}");
        private readonly Regex _regex2 = new Regex(@"\d{13}");
        private readonly string _isbn;
        public List<Author> Authors;
        // ? == nullable
        private readonly DateTime? _publishDate;

        //Constructor
        // finish constructor with exceptions
        public Book(string isbn, DateTime? publishDate, string title, List<Author> authors)
        {
            if (_regex1.IsMatch(isbn) || _regex2.IsMatch(isbn))
            {
                _isbn = isbn;
            }
            else
            {
                throw new ArgumentException();
            }

            _publishDate = publishDate;

            if (title != null && title.Length <= TITLE_LENGHT)
            {
                _title = title;
            }
            else
                throw new ArgumentException();

            Authors = authors;
        }

        public string ISBN { get { return _isbn; } }

        public string Title { get { return _title; } }

        public DateTime? PublishDate { get { return _publishDate; } }

        // Compiler suggesting this alternative:        
        public override bool Equals(object obj) => obj is Book other && Equals(other);

        public override int GetHashCode() => ISBN.GetHashCode();

        public bool Equals(Book other)
        {
            return ISBN.Equals(other.ISBN);
        }

        public bool HasAuthor(string firstName, string lastName)
        {
            return Authors.Any(author => author.FirstName == firstName && author.LastName == lastName);
        }
    }
}
