using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountSystem
{
    public class SavingsAccount : BankAccount
    {
        public decimal InterestRate { get; set; }
        public SavingsAccount(string owner, decimal interestRate)
            : base(owner + $" ({interestRate}%)")
        {
            this.InterestRate = interestRate;
        }

        public override string Deposit(decimal amount)
        {
            decimal interestAmount = (this.InterestRate / 100) * amount;
            amount += interestAmount;
            return base.Deposit(amount);
        }
    }
}
