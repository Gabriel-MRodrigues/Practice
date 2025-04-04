namespace BankAccountSystem
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
            label1 = new Label();
            label2 = new Label();
            btnCreateAccount = new Button();
            btnDeposit = new Button();
            button3 = new Button();
            txtAccountName = new TextBox();
            nmrAmount = new NumericUpDown();
            bankAccountGrid = new DataGridView();
            label3 = new Label();
            nmrInterest = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)nmrAmount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bankAccountGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nmrInterest).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 85);
            label1.Name = "label1";
            label1.Size = new Size(59, 20);
            label1.TabIndex = 0;
            label1.Text = "Owner: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 350);
            label2.Name = "label2";
            label2.Size = new Size(65, 20);
            label2.TabIndex = 1;
            label2.Text = "Amount:";
            // 
            // btnCreateAccount
            // 
            btnCreateAccount.Location = new Point(154, 183);
            btnCreateAccount.Name = "btnCreateAccount";
            btnCreateAccount.Size = new Size(191, 51);
            btnCreateAccount.TabIndex = 2;
            btnCreateAccount.Text = "Create Account";
            btnCreateAccount.UseVisualStyleBackColor = true;
            btnCreateAccount.Click += btnCreateAccount_Click;
            // 
            // btnDeposit
            // 
            btnDeposit.Location = new Point(411, 328);
            btnDeposit.Name = "btnDeposit";
            btnDeposit.Size = new Size(201, 49);
            btnDeposit.TabIndex = 3;
            btnDeposit.Text = "Deposit";
            btnDeposit.UseVisualStyleBackColor = true;
            btnDeposit.Click += btnDeposit_Click;
            // 
            // button3
            // 
            button3.Location = new Point(686, 328);
            button3.Name = "button3";
            button3.Size = new Size(197, 49);
            button3.TabIndex = 4;
            button3.Text = "Withdraw";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // txtAccountName
            // 
            txtAccountName.Location = new Point(154, 78);
            txtAccountName.Name = "txtAccountName";
            txtAccountName.Size = new Size(191, 27);
            txtAccountName.TabIndex = 5;
            // 
            // nmrAmount
            // 
            nmrAmount.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            nmrAmount.Location = new Point(154, 350);
            nmrAmount.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            nmrAmount.Name = "nmrAmount";
            nmrAmount.Size = new Size(191, 27);
            nmrAmount.TabIndex = 6;
            // 
            // bankAccountGrid
            // 
            bankAccountGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            bankAccountGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            bankAccountGrid.Location = new Point(411, 39);
            bankAccountGrid.Name = "bankAccountGrid";
            bankAccountGrid.RowHeadersWidth = 51;
            bankAccountGrid.Size = new Size(472, 244);
            bankAccountGrid.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 133);
            label3.Name = "label3";
            label3.Size = new Size(118, 20);
            label3.TabIndex = 8;
            label3.Text = "Interest Rate (%)";
            // 
            // nmrInterest
            // 
            nmrInterest.Location = new Point(195, 131);
            nmrInterest.Name = "nmrInterest";
            nmrInterest.Size = new Size(150, 27);
            nmrInterest.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(923, 450);
            Controls.Add(nmrInterest);
            Controls.Add(label3);
            Controls.Add(bankAccountGrid);
            Controls.Add(nmrAmount);
            Controls.Add(txtAccountName);
            Controls.Add(button3);
            Controls.Add(btnDeposit);
            Controls.Add(btnCreateAccount);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)nmrAmount).EndInit();
            ((System.ComponentModel.ISupportInitialize)bankAccountGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)nmrInterest).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnCreateAccount;
        private Button btnDeposit;
        private Button button3;
        private TextBox txtAccountName;
        private NumericUpDown nmrAmount;
        private DataGridView bankAccountGrid;
        private Label label3;
        private NumericUpDown nmrInterest;
    }
}
