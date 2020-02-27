using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class BankChild : Bank
    {
        int newAccbal;
        public int Deposit(int Deposit)
        {
            Dep = Deposit;
            int newAccbal = AccBal + Dep;
            Console.WriteLine("New account balance after deposit is " + newAccbal);
            return newAccbal;

        }

        public void add()
        {

        }

        public void sub()
        {
            //test
        }



        static void Main(string[] args)
        {
            BankChild child = new BankChild();
            child.WithdrawBal(1000, 200);
            child.Deposit(500);
           
        }


    }
}
