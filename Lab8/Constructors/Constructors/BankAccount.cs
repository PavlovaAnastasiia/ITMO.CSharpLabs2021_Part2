using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateAccount
{
    public enum AccountType
    {
        Checking, Deposit
    }
    class BankAccount
    {
        private long accNo;
        private decimal accBal;
        private AccountType accType;
        private static long nextAccNo = 123;
        private Queue tranQueue = new Queue();

        public BankAccount()
        {
            accNo = NextNumber();
            accType = AccountType.Checking;
            accBal = 0;
        }
        public BankAccount(AccountType aType)
        {
            accNo = NextNumber();
            accType = aType;
            accBal = 0;
        }
        public BankAccount(decimal aBal)
        {
            accNo = NextNumber();
            accType = AccountType.Checking;
            accBal = aBal;
        }
        public BankAccount(AccountType aType, decimal aBal)
        {
            accNo = NextNumber();
            accType = aType;
            accBal = aBal;
        }
        public long Number()
        {
            return accNo;
        }
        public decimal Balance()
        {
            return accBal;
        }
        public string Type()
        {
            return accType.ToString();
        }
        private static long NextNumber()
        {
            return nextAccNo++;
        }
        public decimal Deposit(decimal amount)
        {
            accBal += amount;
            BankTransaction1.BankTransaction tran = new BankTransaction1.BankTransaction(amount);
            tranQueue.Enqueue(tran);
            return accBal;
        }
        public bool Withdraw(decimal amount)
        {
            bool sufficientFunds = accBal >= amount;
            if (sufficientFunds)
            {
                accBal -= amount;
            }
            BankTransaction1.BankTransaction tran = new BankTransaction1.BankTransaction(-amount);
            tranQueue.Enqueue(tran);
            return sufficientFunds;
        }
        public void TransferFrom(BankAccount accFrom, decimal amount)
        {
            if (accFrom.Withdraw(amount))
                this.Deposit(amount);
        }
        public Queue Transactions()
        {
            return tranQueue;
        }
    }
}
