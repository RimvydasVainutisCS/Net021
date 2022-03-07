// Book(s) properties:
// ISBN; string; Forms: "XXX-X-XX-XXXXXX-X" or "XXXXXXXXXXXXX" where X is a digit 0..9.
// Title of the book; non empty string, limited to 1000 chars.
// Publication date of the book; possibly empty/not set;
// Colletion of book Author(s); possibly empty;

using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Net021
{
    public class Book
    {
        // Variable
        private string _title;
        private const int TITLE_LENGHT = 1000;
        private readonly Regex _regex = new Regex(@"\d+\-*");
        private string _isbn;
        public List<Author> Authors;
        private DateTime _publishDate;

        //Constructor
        // finish constructor with exceptions
        public Book(string isbn, DateTime publishDate, string title, List<Author> authors)
        {
            if(_regex.IsMatch(isbn))
            {
            _isbn = isbn;
            }
            _publishDate = publishDate;
            _title = title;
            Authors = authors;
        }

        public string ISBN
        {
            get { return _isbn; }

            set
            {
                if (_regex.IsMatch(value))
                {
                    _isbn = value;
                }
                else
                {
                    throw new Exception("Please, enter correct ISBN!");
                }
            }
        }
        public string Title
        {
            get { return _title; }
            set
            {
                if (_title != null || _title.Length <= TITLE_LENGHT)
                {
                    _title = value;
                }
                else
                    throw new ArgumentException();
            }
        }
        //overrirde getHash
        public override bool Equals(object obj) => obj is Book && ISBN.Equals(((Book)obj).ISBN);
    }
}
