// First Name; non-empty string; limited to 200 chars;
// Last Name; non-empty string; limited to 200 chars;

namespace Net021
{
    public class Author
    {
        private const int NameLenght = 200;
        private string FirstName
        {
            get { return FirstName; }
            set
            {
                if (FirstName != null || FirstName.Length <= NameLenght)
                {
                    FirstName = value;
                }
            }
        }
        private string LastName
        {
            get { return LastName; }
            set
            {
                if (LastName != null || LastName.Length <= NameLenght)
                {
                    LastName = value;
                }
            }
        }

        public void SetAuthor(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }
}
