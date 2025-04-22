using LMS_BL;

namespace LMS_UnitTests;

[TestClass]
public class BorrowReturnBookTest
{
    private Book _book;
    private Student _student;
    private Teacher _teacher;

    [TestInitialize]
    public void Setup()
    {
        _book = new Book("Murach's C#", "Joel Murach");
        _student = new Student("Gabriel", 508865);
        _teacher = new Teacher("Nick", 123456);
    }
    [TestMethod]
    public void Test_Student_Borrow_Limit()
    {
        // populating Borrow list of student
        for (int i = 0; i <= 10; i++) // trying to add 10 books to Student
        {
            Book newBook = new Book(i.ToString(), i.ToString() + "Author");
            newBook.Borrow(_student);
        }

        Assert.AreEqual(_student.BorrowedBooks.Count, _student.BorrowLimit);
    }

    [TestMethod]
    public void Test_Teacher_Borrow_Limit()
    {
        // populating Borrow list of student
        for (int i = 0; i <= 20; i++) // trying to add 20 books to Teacher
        {
            Book newBook = new Book(i.ToString(), i.ToString() + "Author");
            newBook.Borrow(_teacher);
        }

        Assert.AreEqual(_teacher.BorrowedBooks.Count, _teacher.BorrowLimit);
    }

    [TestMethod]
    public void Test_If_Book_Is_Added_To_User_Book_List()
    {
        _book.Borrow(_student); // adding 1 book to student list

        Assert.AreEqual(_student.BorrowedBooks.Count, 1);
    }

    [TestMethod]
    public void Test_If_Book_Is_Removed_From_User_Book_List()
    {
        _book.Borrow(_student); // adding 1 book to student list
        _book.Return(_student);

        Assert.AreEqual(_student.BorrowedBooks.Count, 0);
    }

    [TestMethod]
    public void Test_If_Book_Has_Already_Been_Borrowed_By_User()
    {
        _book.Borrow(_student); // student borrows book
        _book.Borrow(_teacher); // teacher tries to borrow same book

        Assert.IsFalse(_teacher.BorrowedBooks.Count == 1);
    }
}
