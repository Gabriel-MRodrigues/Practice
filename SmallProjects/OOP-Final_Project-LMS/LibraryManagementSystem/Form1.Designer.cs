namespace LibraryManagementSystem
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dtGridBooks = new DataGridView();
            btnBorrow = new Button();
            btnReturn = new Button();
            btnAddBook = new Button();
            cboUsers = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            btnRemoveBook = new Button();
            ((System.ComponentModel.ISupportInitialize)dtGridBooks).BeginInit();
            SuspendLayout();
            // 
            // dtGridBooks
            // 
            dtGridBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtGridBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtGridBooks.Location = new Point(53, 63);
            dtGridBooks.Name = "dtGridBooks";
            dtGridBooks.ReadOnly = true;
            dtGridBooks.RowHeadersWidth = 51;
            dtGridBooks.Size = new Size(553, 224);
            dtGridBooks.TabIndex = 5;
            // 
            // btnBorrow
            // 
            btnBorrow.Location = new Point(632, 63);
            btnBorrow.Name = "btnBorrow";
            btnBorrow.Size = new Size(135, 36);
            btnBorrow.TabIndex = 1;
            btnBorrow.Text = "Borrow";
            btnBorrow.UseVisualStyleBackColor = true;
            btnBorrow.Click += btnBorrow_Click;
            // 
            // btnReturn
            // 
            btnReturn.Location = new Point(632, 151);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(135, 36);
            btnReturn.TabIndex = 2;
            btnReturn.Text = "Return";
            btnReturn.UseVisualStyleBackColor = true;
            btnReturn.Click += btnReturn_Click;
            // 
            // btnAddBook
            // 
            btnAddBook.Location = new Point(632, 251);
            btnAddBook.Name = "btnAddBook";
            btnAddBook.Size = new Size(135, 36);
            btnAddBook.TabIndex = 3;
            btnAddBook.Text = "Add Book";
            btnAddBook.UseVisualStyleBackColor = true;
            btnAddBook.Click += btnAddBook_Click;
            // 
            // cboUsers
            // 
            cboUsers.Font = new Font("Segoe UI", 11F);
            cboUsers.FormattingEnabled = true;
            cboUsers.Location = new Point(53, 341);
            cboUsers.Name = "cboUsers";
            cboUsers.Size = new Size(228, 33);
            cboUsers.TabIndex = 0;
            cboUsers.SelectedIndexChanged += cboUsers_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(53, 27);
            label1.Name = "label1";
            label1.Size = new Size(91, 25);
            label1.TabIndex = 5;
            label1.Text = "Book List:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(53, 308);
            label2.Name = "label2";
            label2.Size = new Size(135, 25);
            label2.TabIndex = 6;
            label2.Text = "Select an User:";
            // 
            // btnRemoveBook
            // 
            btnRemoveBook.Location = new Point(632, 345);
            btnRemoveBook.Name = "btnRemoveBook";
            btnRemoveBook.Size = new Size(135, 36);
            btnRemoveBook.TabIndex = 4;
            btnRemoveBook.Text = "Remove Book";
            btnRemoveBook.UseVisualStyleBackColor = true;
            btnRemoveBook.Click += btnRemoveBook_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRemoveBook);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cboUsers);
            Controls.Add(btnAddBook);
            Controls.Add(btnReturn);
            Controls.Add(btnBorrow);
            Controls.Add(dtGridBooks);
            Name = "Form1";
            Text = "Library Management System";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dtGridBooks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtGridBooks;
        private Button btnBorrow;
        private Button btnReturn;
        private Button btnAddBook;
        private ComboBox cboUsers;
        private Label label1;
        private Label label2;
        private Button btnRemoveBook;
    }
}
