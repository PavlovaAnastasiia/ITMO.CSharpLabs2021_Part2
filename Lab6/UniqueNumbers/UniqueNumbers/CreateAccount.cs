using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateAccount
{
    class CreateAccount
    {
        static void Main()
        {
            BankAccount berts = NewBankAccount();
            Write(berts);
            TestDeposit(berts);
            Write(berts);
            TestWithDraw(berts);
            Write(berts);

            BankAccount freds = NewBankAccount();
            Write(freds);
            TestDeposit(freds);
            Write(freds);
            TestWithDraw(freds);
            Write(freds);
            Console.ReadKey();
        }
        static BankAccount NewBankAccount()
        {
            BankAccount created = new BankAccount();

            //Console.WriteLine("Please enter the account number: ");
            //long number = long.Parse(Console.ReadLine());
            //long number = BankAccount.NextNumber();

            Console.WriteLine("Please enter the balance number: ");
            decimal balance = decimal.Parse(Console.ReadLine());

            //created.accNo = number;
            //created.accBal = balance;
            //created.accType = AccountType.Checking;

            created.Populate(balance);

            return created;
        }
        static void Write(BankAccount toWrite)
        {
            Console.WriteLine("Account number is {0}", toWrite.Number());
            Console.WriteLine("Account balance is {0}", toWrite.Balance());
            Console.WriteLine("Account type is {0}", toWrite.Type());
        }
        public static void TestDeposit(BankAccount acc)
        {
            Console.Write("Please enter amount to deposit: ");
            decimal amount = decimal.Parse(Console.ReadLine());
            acc.Deposit(amount);
        }
        public static void TestWithDraw(BankAccount acc)
        {
            Console.Write("Enter amount to withdraw: ");
            decimal amount = decimal.Parse(Console.ReadLine());
            if (!acc.Withdraw(amount))
            {
                Console.WriteLine("Insufficient funds.");
            }
        }
    }
}
