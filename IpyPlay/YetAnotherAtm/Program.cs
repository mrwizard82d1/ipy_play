using System;
using Atm;

namespace YetAnotherAtm
{
    class Program
    {
        static void Main()
        {
            var account = GetAccount();
            if (account != null)
            {
                ExecuteTransactions(account);              
            }
        }

        private static void ExecuteTransactions(Account account)
        {
            Console.WriteLine(account); // eliminates warning
            throw new NotImplementedException();
        }

        private static Account GetAccount()
        {
            Console.Write("Account? ");
            string accountNumberText = Console.ReadLine();
            return new Account(accountNumberText);
        }
    }
}
