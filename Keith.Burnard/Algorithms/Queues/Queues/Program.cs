using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queues
{
    class Program
    {
        static Random rand = new Random();

        static void Main(string[] args)
        {
            Queue<Account> accountQueue = new Queue<Account>();
            for (int i = 0; i < 10; i++)
            {                
                // add a new account
                Account account = new Account(rand.Next(1000, 2000), rand.Next(200, 2000));
                accountQueue.Enqueue(account);
            }
            DisplayQueue(accountQueue);

            // remove 2 accounts First In First Out
            accountQueue.Dequeue();
            accountQueue.Dequeue();
            DisplayQueue(accountQueue);

            // add a new account

            // display the account at the front of the line
            Account firstAccount = accountQueue.Peek();
            Console.WriteLine("\r\n{0} {1}", firstAccount.AccountNumber.ToString().PadRight(16), firstAccount.Balance.ToString("c"));

            ProcessAccounts(accountQueue);
            DisplayQueue(accountQueue);


            Console.ReadLine();
        }
        static void DisplayQueue(Queue<Account> queue)
        {
            Console.WriteLine("\n\nAccount Number       Balance");
            foreach (Account account in queue)
            {
                Console.WriteLine("{0} {1}", account.AccountNumber.ToString().PadRight(16), account.Balance.ToString("c"));
            }
        }

        // write a method that processes all the accounts in the queue
        static void ProcessAccounts(Queue<Account> queue)
        {
            Random binaryRand = new Random(1);
            
            foreach (Account account in queue)
            {
                int transactionType = binaryRand.Next();
                decimal transactionAmmount = rand.Next(1000, 2000);

                if (transactionType == 0) // deposit
                {
                    account.Deposit(transactionAmmount);
                }
                else // withdrawl
                {
                    account.Withdrawl(transactionAmmount);
                }
            }

            // generate random amount for the transaction
            // apply transaction
            // display all accounts before and after along with transaction type and ammount

            // do this with a Stack
        }

    }
}
