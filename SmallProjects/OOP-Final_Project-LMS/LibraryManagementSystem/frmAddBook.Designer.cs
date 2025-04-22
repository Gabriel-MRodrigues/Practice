namespace LibraryManagementSystem
{
    partial class frmAddBook
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtTitle = new TextBox();
            btnAdd = new Button();
            txtAuthor = new TextBox();
            label2 = new Label();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(57, 38);
            label1.Name = "label1";
            label1.Size = new Size(52, 25);
            label1.TabIndex = 0;
            label1.Text = "Title:";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(139, 39);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(254, 27);
            txtTitle.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(57, 176);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(126, 49);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(139, 104);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(254, 27);
            txtAuthor.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(57, 103);
            label2.Name = "label2";
            label2.Size = new Size(74, 25);
            label2.TabIndex = 3;
            label2.Text = "Author:";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(267, 176);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(126, 49);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // frmAddBook
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(467, 260);
            Controls.Add(btnCancel);
            Controls.Add(txtAuthor);
            Controls.Add(label2);
            Controls.Add(btnAdd);
            Controls.Add(txtTitle);
            Controls.Add(label1);
            Name = "frmAddBook";
            Text = "Add Book";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtTitle;
        private Button btnAdd;
        private TextBox txtAuthor;
        private Label label2;
        private Button btnCancel;
    }
}