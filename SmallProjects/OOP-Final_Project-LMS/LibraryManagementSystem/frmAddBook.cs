using LMS_BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class frmAddBook : Form
    {
        private Book? _book;
        public frmAddBook()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Text;
            string author = txtAuthor.Text;

            if (isValidInput(title, author))
            {
                _book = new Book(title, author);
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Title and Author fields are required to add a book!");
                txtTitle.Focus();
            }
        }

        private bool isValidInput(string title, string author)
        {
            bool isValid = false;
            if (title != string.Empty && author != string.Empty)
                isValid = true;
            return isValid;
        }

        public Book? GetBook()
        {
            return _book;
        }
    }
}
