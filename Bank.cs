using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Bank
    {
        protected int AccBal;
        protected int Withdraw;
        protected int Dep;

        public int WithdrawBal(int AccountBalance, int Withdrawal)
        {
            AccBal = AccountBalance;
            Withdraw = Withdrawal;
            AccBal = AccountBalance - Withdraw;
            Console.WriteLine("Account balance after withdrawal is " + AccBal);
            return AccBal;

        }

    }
}
