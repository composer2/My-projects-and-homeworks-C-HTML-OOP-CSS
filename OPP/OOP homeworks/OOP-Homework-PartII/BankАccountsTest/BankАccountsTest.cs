using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankАccountsTest
{
    class BankАccountsTest
    {
        static void Main(string[] args)
        {

            //adds accounts
            var bank = new Bank();
            bank.AddAccount(new Deposit(new Individual("Bobka Bobev"), 20000, 0.02M));
            bank.AddAccount(new Deposit(new Company("Boni M LTD"), 20000, 0.04M));
            bank.AddAccount(new Loan(new Individual("John Atanasov"), 45000, 0.05M));
            bank.AddAccount(new Loan(new Company("IT Tech"), 120000, 0.03M));
            bank.AddAccount(new Mortgage(new Individual("Sandra Gerry"), 2400, 0.08M));
            bank.AddAccount(new Mortgage(new Company("Left Hand Corp."), 600000, 0.05M));

            //calculates interest rate n print
            var monthsContract = new Random();
            var counter = 1;
            foreach (var account in bank.Accounts)
            {
                //random generated months
                var months = monthsContract.Next(1, 60);
                Console.WriteLine("Account: {0}, Type: {1}", counter, account.GetType().Name);
                Console.WriteLine(account.ToString());
                Console.WriteLine("Interest rate for {0} months: {1}", months, account.CalculateInterestRate(months));
                Console.WriteLine(new string('*', 40));
                counter++;
            }
        }
    }
}
