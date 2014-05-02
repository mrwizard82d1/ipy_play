using System;
using Atm;

namespace YetAnotherAtm
{
    class Program
    {
        static void Main(string[] args)
        {
            var accountNumber = GetAccountNumber();
            if (accountNumber != null)
            {
                ExecuteTransactions(accountNumber);              
            }
        }

        private static void ExecuteTransactions(AccountNumber accountNumber)
        {
            throw new NotImplementedException();
        }

        private static AccountNumber GetAccountNumber()
        {
            Console.Write("Account? ");
            string accountNumberText = Console.ReadLine();
            AccountNumber accountNumber = null;
            AccountNumber.TryParse(accountNumberText, out accountNumber);
            return accountNumber;
        }
    }
}
