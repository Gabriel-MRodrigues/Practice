using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LMS_BL
{
    public class Book : IBorrowable
    {
        public  string Title { get; set; }
        public string Author { get; set; }
        public bool IsAvailable { get; set; }
        public string BorrowedBy { get; private set; }

        // Creating event to handle exceptions and to display to the final user instead of just using the Debug console
        public delegate void ShowMessage(string message);
        public event ShowMessage? bookEvent;

        public Book(string title, string author)
        {
            this.Title = title;
            this.Author = author;
            this.IsAvailable = true; // setting default value when Book is instantiated
            this.BorrowedBy = "None"; // setting default value when Book is instantiated
        }

        public override string ToString()
        {
            // overriding ToString() method
            return $"{this.Title}|{this.Author}|{(IsAvailable ? "Is Available" : "Not Available")}|{this.BorrowedBy}";
        }

        public override bool Equals(object? obj)
        {
            if (obj is Book book) // checks if obj is of type Book and then assign it's value to the variable book
            {
                return this.Title == book.Title && this.Author == book.Author;
            }
            return false;
        }

        public void Borrow(User user)
        {
            // Borrow method
            string message = "";
            if (this.IsAvailable)
            {
                switch (user)
                {
                    case Student student:
                        message = CheckBorrowLimit(student);
                        break;
                    case Teacher teacher:
                        message = CheckBorrowLimit(teacher);
                        break;
                    case Librarian librarian:
                        message = CheckBorrowLimit(librarian);
                        break;
                    default:
                        message += "Unknown User Type.";
                        break;
                }
             }
            else
            {
                message += $"'{this.Title}' has already been borrowed and it is not available anymore...";
            }
            Debug.WriteLine(message);
            // Invoking Event
            bookEvent?.Invoke(message);
        }

        public void Return(User user)
        {
            // Return Method
            string message = "";
            if (!this.IsAvailable)
            {
                switch (user)
                {
                    case Student student:
                        message = CheckBorrowedBooks(student);
                        break;
                    case Teacher teacher:
                        message = CheckBorrowedBooks(teacher);
                        break;
                    case Librarian librarian:
                        message = CheckBorrowedBooks(librarian);
                        break;
                    default:
                        message += "Unkown User Type";
                        break;
                }
            }
            else
            {
                message += $"'{this.Title}' is already available to borrow!";
            }
            Debug.WriteLine(message);
            // Invoking Event
            bookEvent?.Invoke(message);
        }

        private string CheckBorrowedBooks(User user)
        {
            // Checks if User has book on their list of Books
            if (user.BorrowedBooks.Contains(this))
            {
                // remove book from user borrowed books list and updates book properties
                user.BorrowedBooks.Remove(this);
                this.IsAvailable = true;
                this.BorrowedBy = "None";
                return $"{user.Name} has returned '{this.Title}'!"; 
            }
            else
            {
                return $"{user.Name} do not have '{this.Title}' on their borrowed book list...";
            }
        }

        private string CheckBorrowLimit(User user)
        {
            int? borrowLimit = user switch
            {
                Student => 5,
                Teacher => 10,
                _ => null // librarian
            };

            bool canBorrow = borrowLimit == null || user.BorrowedBooks.Count < borrowLimit;

            if (canBorrow)
            {
                // add book to user Book list and change Book properties
                user.BorrowedBooks.Add(this);
                this.IsAvailable = false;
                this.BorrowedBy = user.Name;
                return $"{user.Name} has borrowed '{this.Title}'!";
            }
            else
            {
                return $"{user.Name} has reached his borrow limit...";
            }
        }

        public static bool operator ==(Book book1, Book book2)
        {
            // operator overloading comparing books fields
            return book1.Title == book2.Title && book1.Author == book2.Author;
        }

        public static bool operator !=(Book book1, Book book2)
        {
            // operator overloading comparing books fields
            return book1.Title != book2.Title || book1.Author != book2.Author;
        }
    }
}
