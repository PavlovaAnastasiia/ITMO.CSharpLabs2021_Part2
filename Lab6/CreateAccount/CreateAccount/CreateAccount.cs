using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateAccount
{
    class CreateAccount
    {
        static void Main(string[] args)
        {
        }
        static BankAccount NewBankAccount()
        {
            BankAccount created = new BankAccount();

            Console.WriteLine("Please enter the account number: ");
            long number = long.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the balance number: ");
            decimal balance = decimal.Parse(Console.ReadLine());

            //created.accNo = number;
            //created.accBal = balance;
            //created.accType = AccountType.Checking;
            created.Populate(number, balance);

            return created;
        }
        static void Write(BankAccount toWrite)
        {
            Console.WriteLine("Account number is {0}", toWrite.Number());
            Console.WriteLine("Account balance is {0}", toWrite.Balance());
            Console.WriteLine("Account type is {0}", toWrite.Type());
        }
    }
}
