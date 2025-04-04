namespace BankAccountSystem
{
    public partial class Form1 : Form
    {
        private List<BankAccount> bankAccounts = new List<BankAccount>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            string owner = txtAccountName.Text;

            if (!string.IsNullOrEmpty(owner))
            {
                owner = FormatName(owner);
                if(nmrInterest.Value == 0)
                {
                    bankAccounts.Add(new BankAccount(owner));
                }
                else
                {
                    decimal interestRate = nmrInterest.Value;
                    bankAccounts.Add(new SavingsAccount(owner, interestRate));
                }
                    bankAccountGrid.DataSource = bankAccounts;
                RefreshGrid();
            }

            nmrInterest.Value = 0;
            txtAccountName.Clear();
            txtAccountName.Focus();

        }

        private void RefreshGrid()
        {
            bankAccountGrid.DataSource = null;
            bankAccountGrid.DataSource = bankAccounts;
        }

        private string FormatName(string str)
        {
            string formattedName = "";
            List<string> names = new List<string>(str.Split(' '));
            foreach (string name in names)
            {
                formattedName += char.ToUpper(name[0]) + name.Substring(1).ToLower() + " ";
            }
            return formattedName;
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            if (bankAccountGrid.SelectedRows.Count == 1)
            {
                BankAccount selectedBankAccount = bankAccountGrid.SelectedRows[0].DataBoundItem as BankAccount;
                string message = selectedBankAccount.Deposit(nmrAmount.Value);
                RefreshGrid();
                MessageBox.Show(message);
                nmrAmount.Value = 0;
            }
            else
            {
                MessageBox.Show("You must select a bank account and amount must be greater than 0");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (bankAccountGrid.SelectedRows.Count == 1)
            {
                BankAccount selectedBankAccount = bankAccountGrid.SelectedRows[0].DataBoundItem as BankAccount;
                string message = selectedBankAccount.Withdrawl(nmrAmount.Value);
                RefreshGrid();
                MessageBox.Show(message);
                nmrAmount.Value = 0;
            }
            else
            {
                MessageBox.Show("You must select a bank account and amount must be greater than 0");
            }
        }
    }
}
