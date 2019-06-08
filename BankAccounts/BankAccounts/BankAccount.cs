using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
namespace BankAccounts
{
    public class BankAccountNew
    {
        public string Number { get; }
        public string Owner { get; set; }
        public decimal Balance
        {

            get
            {
                decimal balance = 0;
                foreach (var item in allTransactions)
                {
                    balance += item.Amount;
                }
                return balance;
            }


        }

        private static int accountnumberseed = 1234567890;
        private List<Transaction> allTransactions = new List<Transaction>();
        public void MakeDeposit(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of deposite must be positive");
            }
            var deposit = new Transaction(amount, date, note);
            allTransactions.Add(deposit);
        }

        public void MakeWithdrawal(decimal amount, DateTime date, string note)
        {
            if(amount <=0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount),"Amount of Withdrawal must be positive");
            }
            if(Balance - amount <=0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Not sufficient funds for this withdrawal");
            }
            var withdrawal = new Transaction(-amount, date, note);
            allTransactions.Add(withdrawal);
        }
        public string GetAccountHistory()
        {
            var report = new System.Text.StringBuilder();

            report.AppendLine("Date\tAmount\tNote");
            foreach (var item in allTransactions)
            {
                report.AppendLine($"{item.Date.ToShortDateString()}\t{item.Amount}\t{item.Notes}");
            }

            return report.ToString();
        }
        public BankAccountNew(string name, decimal InitialBalance)
        {
            this.Owner = name;
            MakeDeposit(InitialBalance, DateTime.Now, "Initial Balance");
            this.Number = accountnumberseed.ToString();
            accountnumberseed++;
        }


    }


}
