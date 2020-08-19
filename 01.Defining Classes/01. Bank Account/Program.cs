using System;

namespace _01._Bank_Account
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount bankAccount = new BankAccount(1, 100);
            Console.WriteLine(bankAccount.Balance);

            bankAccount.Deposit(900);
            bankAccount.Withdraw(50);
            Console.WriteLine(bankAccount.ToString());
        }
    }
}
