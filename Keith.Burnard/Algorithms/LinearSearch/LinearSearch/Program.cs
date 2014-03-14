using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Account> accountList = new List<Account>();
            InitializeAccountList(accountList);

            int selection;
            do
            {
                Console.WriteLine(" 1. search \n 2. deposit \n 3. withdrawl \n 4.display all \n 0.exit");
                Console.Write("\n Enter your selection: ");
                int.TryParse(Console.ReadLine(), out selection);
                switch (selection)
                {
                    case 1: // find account
                        {
                            Console.Write(" Please enter the account number: ");
                            int accountNumber;
                            int.TryParse(Console.ReadLine(), out accountNumber);
                            Account account = GetAccount(accountList, accountNumber);
                            if(account != null)
                            {
                                Console.WriteLine("The account ballance is: {0,c}", account.Balance);                               
                            }
                            else
                            {
                                Console.WriteLine("Account not found");
                            }
                            break;
                        }
                    case 2: // deposit
                        {
                            Console.Write(" Please enter the account number: ");
                            int accountNumber;                           
                            int.TryParse(Console.ReadLine(), out accountNumber);

                            Console.Write(" Please enter the deposit ammount: ");
                            int depostitAmount;
                            int.TryParse(Console.ReadLine(), out depostitAmount);

                            Account account = GetAccount(accountList, accountNumber);
                            if (account != null)
                            {
                                account.Deposit(depostitAmount);
                                Console.WriteLine("The new account ballance is: {0,c}", account.Balance);
                            }
                            else
                            {
                                Console.WriteLine("Account not found");
                            }
                            break;
                        }
                    case 3: // withdrawl
                        {
                            Console.Write(" Please enter the account number: ");
                            int accountNumber;
                            int.TryParse(Console.ReadLine(), out accountNumber);

                            Console.Write(" Please enter the withdrawl ammount: ");
                            int withdrawlAmount;
                            int.TryParse(Console.ReadLine(), out withdrawlAmount);

                            Account account = GetAccount(accountList, accountNumber);
                            if (account != null)
                            {
                                account.Withdrawl(withdrawlAmount);
                                Console.WriteLine("The new account ballance is: {0,c}", account.Balance);
                            }
                            else
                            {
                                Console.WriteLine("Account not found");
                            }
                            break;
                        }
                    case 4: // display
                        {
                            DisplayAll(accountList);
                            break;
                        }
                    case 0: // exit
                        {
                            break;
                        }
                }

            }while (selection !=0);

            Console.WriteLine("Hit any key to continue");
            Console.ReadLine();
        }
        static void InitializeAccountList(List<Account> list)
        {
            Random rand = new Random();
            for (int i = 0; i < 5; i++)
            {
                int accum = rand.Next(1000, 2000);
                decimal balance = rand.Next(400, 50000);
                list.Add(new Account(accum,balance));
            }
        }

        static Account GetAccount(List<Account> list, int accountNumber)
        {
            foreach (Account account in list)
            {
                if (accountNumber == account.AccountNumber)
                {
                    return account;
                }
            }
            return null;
        }

        static void BubbleSort(List<Account> list)
        {
            for (int i = 1; i < list.Count - 1; i++) // stop one up from the end of the list
            {
                for (int j = 0; j < list.Count - i; j++)
                {
                    if (list[j].CompareTo(list[j + 1]) > 0)
                    {
                        swap<Account>(j, j + 1, list);
                    }
                }
            }
        }
        static void swap<T>(int i, int j, List<T> list) // generic T
        {
            T temp = list[i];
            list[i] = list[j];
            list[j] = temp;
        }

        static void DisplayAll(List<Account> list)
        {
            Console.WriteLine("\n\nAccount Number       Balance");
            foreach (Account account in list)
            {
                Console.WriteLine("{0} {1}", account.AccountNumber.ToString().PadLeft(10), account.Balance.ToString("c"));
            }
        }
        static Account IterativeBinarySearch(List<Account> list, int accountNumber)
        {
            Account account = GetAccount(list, accountNumber);
            int low = 0;
            int high = list.Count - 1;
            int mid = -1;

            while (low <= high)
            {
                mid = (low + high) / 2;
                if (account.Balance.CompareTo(list[mid].Balance) > 0)
                {
                    low = mid + 1;
                }
                else if (account.Balance.CompareTo(list[mid].Balance) < 0)
                {
                    high = mid - 1;
                }
                else
                    break;
            }
            if (low <= high)
            {
                return list[mid];
            }
            else
            {
                return null;
            }
        }
        // exercise
        // rewrite the binary search for generic (generic binarySearch)
        //
        // time the sequential search before sorting
        // sort the list
        // time the iterative binary search
        //
    }
}
