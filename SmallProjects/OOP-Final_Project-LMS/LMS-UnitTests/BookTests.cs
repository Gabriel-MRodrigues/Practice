using LMS_BL;

namespace LMS_UnitTests
{
    [TestClass]
    public sealed class BookTests
    {
        private Book _book;
        private Student _student;

        [TestInitialize]
        public void Setup()
        {
            _book = new Book("Murach's C#", "Joel Murach");
            _student = new Student("Gabriel", 508865);
        }

        [TestMethod]
        public void Test_If_Book_Is_Marked_As_Available_Once_Instantiated()
        {
            Assert.IsTrue(_book.IsAvailable);
        }

        [TestMethod]
        public void Test_If_Book_Is_Marked_As_Unavailable_Once_Borrowed()
        {
            _book.Borrow(_student);

            Assert.IsFalse(_book.IsAvailable);
        }

        [TestMethod]
        public void Test_If_Book_Is_Marked_As_Available_Once_Returned()
        {
            _book.Borrow(_student); // adding book to Student Borrowed Book List -> IsAvailable = false
            _book.Return(_student);

            Assert.IsTrue(_book.IsAvailable);
        }

        [TestMethod]
        public void Test_If_Books_Are_Equal()
        {
            // using AreEqual()
            Book newBook = new Book("Murach's C#", "Joel Murach");

            Assert.AreEqual(_book, newBook);
        }

        [TestMethod]
        public void Test_If_Books_Are_Equal_Using_Operators()
        {
            Book newBook = new Book("Murach's C#", "Joel Murach");

            Assert.IsTrue(_book == newBook);
        }

        [TestMethod]
        public void Test_If_Books_Are_NOT_Equal_Using_Operators()
        {
            // Completely Different
            Book newBook = new Book("Moby Dick", "Herman Melville");

            Assert.IsTrue(_book != newBook);
        }

        [TestMethod]
        public void Test_Same_Author_Different_Title()
        {
            // Author the same, Title different
            Book newBook = new Book("MySQL", "Joel Murach");

            Assert.IsTrue(_book != newBook);
            Assert.IsFalse(_book == newBook);
        }
    }
}
