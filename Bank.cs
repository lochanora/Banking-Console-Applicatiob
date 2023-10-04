using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class Bank
    {
        static void Main(string[] args)
        {
            List<Account> accounts = new List<Account>();
            Console.WriteLine("Enter the number of months to deposit: ");
            string monthsInput = Console.ReadLine();
            while (true) 
            {

                Console.WriteLine("Enter the Customer's name: ");
                string name = Console.ReadLine();

                if (string.IsNullOrEmpty(name))
                { break; }

                int months = int.Parse(monthsInput);

                Console.WriteLine($"Enter {name}'s initial Deposit Amount (minimum $1,000.00): ");
                double initialDeposit = double.Parse (Console.ReadLine()); //used to convert the string input to a double data type.

                Console.WriteLine($"Enter {name}'s Monthly Deposit Amount (minimum $50.00): ");
                double monthlyDeposit = double.Parse(Console.ReadLine());

                Account account = new Account(name, initialDeposit, monthlyDeposit);
                accounts.Add(account);
            }

            foreach (Account account in accounts)
            {
                account.UpdateBalance();
                Console.WriteLine($"After 8 months, {account.OwnerName}'s account #{account.AccountNumber}, has a balance of: ${account.Balance.ToString("0.00")}");//The balance is displayed with two decimal places.

            }
            Console.WriteLine("Press Enter to complete.");
            Console.Read();
        }
    }
}
