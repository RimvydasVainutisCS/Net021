// First Name; non-empty string; limited to 200 chars;
// Last Name; non-empty string; limited to 200 chars;

using System;

namespace Net021
{
    public class Author
    {
        private const int NameLenght = 200;

        // readonly -- setting only from constructor
        private readonly string _firstName;
        private readonly string _lastName;
        public string FirstName
        {
            get { return _firstName; }
        }
        public string LastName
        {
            get { return _lastName; }
        }
        // Constructor
        public Author(string firstName, string lastName)
        {
            ValidateName(firstName);
            _firstName = firstName;
            ValidateName(lastName);
            _lastName = lastName;
        }

        private void ValidateName(string name)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (name.Length > NameLenght)
            {
                throw new ArgumentException("Field is too long.", nameof(name));
            }
        }
    }
}
