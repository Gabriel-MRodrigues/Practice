using System.Configuration;
using LMS_BL;

namespace LibraryManagementSystem
{
    public partial class Form1 : Form
    {
        private Book? _book;
        private List<Book> _books = new List<Book>(); // creating book list to store books
        private List<User> _users = new List<User>() // creating user list for the users
            {
                new Student("Gabriel", 508865),
                new Teacher("Nick", 123456),
                new Librarian("Sarah", 654321),
            };


        Book.ShowMessage bookDelegate;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnAddBook.Enabled = false;
            btnRemoveBook.Enabled = false;

            foreach (User user in _users)
            {
                cboUsers.Items.Add(user.Role);
            }

            RefreshBookGrid(_books);
        }

        private void cboUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboUsers.SelectedItem == "Librarian")
            {
                btnAddBook.Enabled = true;
                btnRemoveBook.Enabled = true;
            }
            else
            {
                btnAddBook.Enabled = false;
                btnRemoveBook.Enabled = false;
            }
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            frmAddBook frmAddBook = new frmAddBook();
            DialogResult result = frmAddBook.ShowDialog();
            if (result == DialogResult.OK)
            {
                _book = frmAddBook.GetBook();
                if(_book is not null)
                {
                    _books.Add(_book);
                    // Subscribing to event
                    bookDelegate = new Book.ShowMessage(ShowMessage);
                    _book.bookEvent += bookDelegate;
                }
                RefreshBookGrid(_books);
            }
            else
            {
                MessageBox.Show("No books added");
                RefreshBookGrid(_books);
            }
        }

        private void RefreshBookGrid(List<Book> books)
        {
            dtGridBooks.Rows.Clear();
            dtGridBooks.Columns.Clear();

            dtGridBooks.Columns.Add("title", "Title");
            dtGridBooks.Columns.Add("author", "Author");
            dtGridBooks.Columns.Add("isAvailable", "Is Available");
            dtGridBooks.Columns.Add("borrowedBy", "Borrowed By");

            foreach (Book book in books)
            {
                string[] fields = book.ToString().Split("|");
                dtGridBooks.Rows.Add(fields);
            }
        }

        private void btnRemoveBook_Click(object sender, EventArgs e)
        {
            if (dtGridBooks.SelectedRows.Count > 0 && dtGridBooks.SelectedRows[0].Cells[0].Value != null)
            {
                string? selectedBook = dtGridBooks.SelectedRows[0].Cells[0].Value.ToString(); // select book by title
                DialogResult result = MessageBox.Show($"Are you sure you want to remove '{selectedBook}'?", "Removing Book", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    _books.RemoveAll(book => book.Title == selectedBook);
                    RefreshBookGrid(_books);
                }
            }
            else
            {
                MessageBox.Show("You need to select a book first");
            }
        }

        private User? GetUser()
        {
            User? user = null;
            if (dtGridBooks.SelectedRows.Count > 0 && dtGridBooks.SelectedRows[0].Cells[0].Value != null)
            {
                string? selectedBookTitle = dtGridBooks.SelectedRows[0].Cells[0].Value.ToString();
                switch (cboUsers.SelectedItem)
                {
                    case "Student":
                        user = _users[0];
                        break;
                    case "Teacher":
                        user = _users[1];
                        break;
                    case "Librarian":
                        user = _users[2];
                        break;
                    default:
                        MessageBox.Show("You must select an user first.");
                        break;
                }
            }
            else
            {
                MessageBox.Show("You must select one book first.");
            }
            return user;
        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            User? user = GetUser();
            if (user != null)
            {
                string? selectedBookTitle = dtGridBooks.SelectedRows[0].Cells[0].Value.ToString();
                _book = _books.Find(book => book.Title == selectedBookTitle);
                _book?.Borrow(user);
                RefreshBookGrid(_books);
            }
        }

        private void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            User? user = GetUser();
            if(user != null)
            {
                string? selectedBookTitle = dtGridBooks.SelectedRows[0].Cells[0].Value.ToString();
                _book = _books.Find(book => book.Title == selectedBookTitle);
                _book?.Return(user);
                RefreshBookGrid(_books);
            }
        }
    }
}
