using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_management
{
    public class SavingsAccount : Account
    {
        public decimal InterestRate;

        public SavingsAccount(int accountNumber, string holderName, decimal initialBalance, decimal interestRate) : base(accountNumber, holderName, initialBalance)
        {
            InterestRate = interestRate;
        }
        public void CalculateInterest()
        {
            decimal interest = Balance * InterestRate / 100;
            Deposit(interest);
            Console.WriteLine($"Interest of {interest:C} added at rate {InterestRate}%.");
        }




    }
}
