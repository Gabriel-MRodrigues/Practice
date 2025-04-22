using System.Reflection.Metadata.Ecma335;

namespace LMS_BL
{
    public abstract class User
    {
        public string Name { get; set; }
        public int UserId { get; set; }
        public string Role { get; set; }

        public List<Book> BorrowedBooks { get; set; }

        public User(string Name, int UserId, string Role)
        {
            this.Name = Name;
            this.UserId = UserId;
            this.Role = Role;
            this.BorrowedBooks = new List<Book>(); // create list
         }
        public abstract void DisplayRole();
    }
}
