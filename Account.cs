using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class Account
    {
        public int AccountNumber { get; } //'get'the meaning of can't be modified externally.
        public string OwnerName { get; set; }
        public double Balance { get; set; }//ensures the Balance can only be modified within the Account class. 
        public double MonthlyDepositAmount { get; set; } // only use "get" property becomes read-only
        

        public static double MonthlyFee  = 4.0;
        public static double MonthlyInterestRate  = 0.0025;
        public static double MinimumInitialBalance  = 1000;
        public static double MaximumMonthDeposit  = 50;

        public Account(string ownerName, double initialDeposit,  double monthlyDeposit) 
        { 
            this.OwnerName = ownerName;
            this.Balance = initialDeposit;
            this.MonthlyDepositAmount = monthlyDeposit;
            this.AccountNumber = RandomGeneratedNumber();
            
        }

        private static int RandomGeneratedNumber()
        {
            var random = new Random();
            return random.Next(90000, 99999);
        }
        public double Deposit (double amount)
        {
            Balance += amount;
            return Balance;
        }
        public double withdraw(double amount)
        {
            Balance -= amount;
            return Balance;
        }


        public void UpdateBalance()
        {
            for (int i = 0; i < 8; i++) 
            {
                Balance -= MonthlyFee;
                Balance += Balance * MonthlyInterestRate;
                Balance += MonthlyDepositAmount;
            }
        }
    }
}
