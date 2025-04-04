using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountSystem
{
    public class BankAccount
    {
        public string Owner {  get; set; }
        public Guid AccountNumber { get; set; } // Guid generates a unique ID every time we call it
        public decimal Balance { get; protected set; }

        public BankAccount(string owner) {
            this.Owner = owner;
            this.AccountNumber = Guid.NewGuid();
            this.Balance = 0;
        }

        public virtual string Deposit(decimal amount) {
            decimal limit = 20000;
            if (amount < 0) return $"You cannot deposit negative numbers";
            if(amount > limit) return $"You cannot deposit this much money ${amount.ToString("C")}";

            this.Balance += amount;
            return $"{amount.ToString("C")} deposit completed";
        }

        public string Withdrawl(decimal amount)
        {
            if (amount < 0) return $"You cannot withdrawl negative numbers";
            if (amount > this.Balance) return $"You don't have enough money";

            this.Balance -= amount;
            return $"{amount.ToString("C")} deposit completed";
        }

    }
}
