using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atm
{
    public class Atm
    {
        public decimal WithdrawCash(Account account, decimal amount)
        {
            if (account.Balance - amount > account.MinimumBalance)
            {
                account.Debit(amount);
                return amount;
            }

            return 0;
        }
    }
}
