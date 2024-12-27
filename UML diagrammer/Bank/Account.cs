using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_management
{
    public class Account
    {
        public int AccountNumber { get; set; }
        public string AccountHolderName { get; set; }
        public decimal Balance { get; private set; }

        public Account(int accountNumber, string accountHolderName, decimal initialBalance)
        {
            AccountNumber = accountNumber;
            AccountHolderName = accountHolderName;
            Balance = initialBalance;
        }

        public void Deposit(decimal amount)
        {
            Balance += amount;
            Console.WriteLine($"Deposited {amount:C}. New Balance: {Balance:C}");
        }

        public void Withdraw(decimal amount)
        {
            if (Balance > 0 && Balance >= amount)
            {
                Balance -= amount;
                Console.WriteLine($"Withdrew {amount:C}. New Balance: {Balance:C}");
            }
            else
            {
                Console.WriteLine( "insufficient funds");
            }
        }

        public void DisplayAccountDetails()
        {
            Console.WriteLine($"\nAccount Number: {AccountNumber}, Holder: {AccountHolderName}, Balance: {Balance:C}");
        }
    }
}
