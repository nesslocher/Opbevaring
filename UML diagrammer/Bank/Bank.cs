using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_management
{
    public class Bank
    {
        public string BankName { get; set; }
        public List<Account> Accounts { get; set; } = new List<Account>();

        public Bank(string bankName)
        {
            BankName = bankName;
        }

        public void AddAccount(Account account)
        {
            Accounts.Add(account);
            Console.WriteLine($"Account {account.AccountNumber} added to {BankName}.");
        }

        public void RemoveAccount(int accountNumber)
        {
            var account = GetAccount(accountNumber);
            if (account != null)
            {
                Accounts.Remove(account);
                Console.WriteLine($"Account {accountNumber} removed.");
            }
            else
            {
                Console.WriteLine($"Account {accountNumber} not found.");
            }
        }

        public Account GetAccount(int accountNumber)
        {
            return Accounts.Find(acc => acc.AccountNumber == accountNumber);
        }

        public void DisplayAllAccount()
        {
            Console.WriteLine($"\nAccounts in {BankName}:");
            foreach (var account in Accounts)
            {
                account.DisplayAccountDetails();
            }
        }
    }
}
