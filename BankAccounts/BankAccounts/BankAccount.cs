using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts
{
    public class BankAccountNew
    {
        public string Number { get; }
        public string Owner { get; set; }
        public decimal Balance { get; }

        private static int accountnumberseed = 1234567890;
        public void MakeDeposit(decimal amount, DateTime date, string note)
        {

        }

        public void MakeWithdrawal(decimal amount, DateTime date, string note)
        {
            
        }

        public BankAccountNew(string name, decimal InitialBalance)
        {
            this.Owner = name;
            this.Balance = InitialBalance;
            this.Number = accountnumberseed.ToString();
            accountnumberseed++;
        }
     
        
    }
 

}
