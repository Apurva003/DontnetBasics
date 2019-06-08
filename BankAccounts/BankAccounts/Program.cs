using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccountNew("Apurva", 4000);
            account.MakeWithdrawal(500, DateTime.Now, "rent for this month");
            Console.WriteLine(account.Balance);
            account.MakeDeposit(100, DateTime.Now, "friend piad me back");
            Console.WriteLine(account.Balance);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance} initial balance");
            Console.WriteLine(account.GetAccountHistory());
            Console.ReadLine();
        }
    }
}
