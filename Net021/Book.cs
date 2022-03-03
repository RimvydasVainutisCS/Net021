// Book(s) properties:
// ISBN; string; Forms: "XXX-X-XX-XXXXX-X" or "XXXXXXXXXXXX" where X is a digit 0..9.
// Title of the book; non empty string, limited to 1000 chars.
// Publication date of the book; possibly empty/not set;
// Colletion of book Author(s); possibly empty;

using System;
using System.Collections.Generic;

namespace Net021
{
    public class Book
    {
        private const int TitleLenght = 1000;

        public string ISBN { get; set; }

        private DateTime PublishDate;

        private List<Author> Authors {get; set;}

        private string Title
        {
            get { return Title; }
            set
            {
                if (Title != null || Title.Length <= TitleLenght)
                {
                    Title = value;
                }
            }
        }

        //public void SetAuthors(string name, string surname)
        //{
        //    authors.Add(name, surname);
        //}
    }
}
