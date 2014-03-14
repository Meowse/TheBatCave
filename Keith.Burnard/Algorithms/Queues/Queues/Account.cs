using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queues
{
    public class Account :IComparable<Account> // allows the comparison of objects
    {
        private int _accountNumber;
        private decimal _balance;

        public Account(int accountNumber, decimal balance)
        {
            this._accountNumber = accountNumber;
            this._balance = balance;
        }

        public int AccountNumber
        { get { return this._accountNumber; } }

        public decimal Balance
        { get { return this._balance; } }

        public void Deposit(decimal amount)
        {
            this._balance += amount;
        }

        public bool Withdrawl(decimal amount)
        {
            if (_balance > amount)
            {
                this._balance -= amount;
                return true;
            }
            _balance -= 15; // overdraft fee
            return false;            
        }

        public int CompareTo(Account other)
        {
            //if(this.Balance > other.Balance) {return 1;}
            //if (this.Balance < other.Balance) { return -1; }
            //return 0;

            return this.Balance.CompareTo(other.Balance);
        }
    }
}
