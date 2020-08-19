using System;
using System.Collections.Generic;
using System.Text;

namespace _01._Bank_Account
{
    class BankAccount
    {
        private int id;
        private decimal balance;

        public BankAccount()
        {

        }

        public BankAccount(int id)
        {
            this.id = id;
        }

        public BankAccount(int id, decimal balance) : this(id)
        {
            this.balance = balance;
        }

        public decimal Balance
        {
            get
            {
                return this.balance;
            }

            set
            {
                this.balance = value;
            }
        }

        public void Deposit(decimal amount)
        {
            balance += amount;
        }

        public decimal Withdraw(decimal amount)
        {
            if (balance >= amount)
            {
                balance -= amount;
                return amount;
            }
            throw new ArgumentException("Insufficient amount!");
        }

        public override string ToString()
        {
            return $"Your balance is {balance}";
        }

    }
}
