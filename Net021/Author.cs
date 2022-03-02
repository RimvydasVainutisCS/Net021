// First Name; non-empty string; limited to 200 chars;
// Last Name; non-empty string; limited to 200 chars;

namespace Net021
{
    public class Author
    {
        private string FirstName
        {
            get { return FirstName; }
            set
            {
                if (FirstName != null || FirstName.Length <= 200)
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
                if (LastName != null || LastName.Length <= 200)
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
