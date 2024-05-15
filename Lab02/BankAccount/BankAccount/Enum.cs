using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public enum AccounType { Checking, Deposit }
    internal class Enum
    {
        static void Main(string[] args)
        {
            AccounType goldAccount;
            AccounType platinumAccount;
            goldAccount = AccounType.Checking;
            platinumAccount = AccounType.Deposit;
            Console.WriteLine("The Costomer Account Type is {0}", goldAccount);
            Console.WriteLine("The Costomer Account Type is {0}", platinumAccount);
        }
    }
}
