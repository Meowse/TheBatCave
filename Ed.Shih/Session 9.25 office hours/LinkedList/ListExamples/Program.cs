using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinkedList;

namespace ListExamples
{
    class Program
    {
        static void Main(string[] args)
        {
//            Node head = new Node();
//            head.Value = new Person {FirstName = "Fred", LastName = "Flintstone"};
//            head.Next = new Node();
//            head.Next.Value = new Person {FirstName = "Barney", LastName = "Rubble"};
//            head.Next.Next = null;

//            Node secondNode = new Node();
//            secondNode.Value = new Person { FirstName = "Barney", LastName = "Rubble" };
//            secondNode.Next = null;
//
//            Node head = new Node();
//            head.Value = new Person { FirstName = "Fred", LastName = "Flintstone" };
//            head.Next = secondNode;

            Node head = new Node
            {
                Value = new Person {FirstName = "Fred", LastName = "Flintstone"},
                Next = new Node
                {
                    Value = new Person {FirstName = "Barney", LastName = "Rubble"},
                    Next = new Node
                    {
                        Value = new Person { FirstName = "Wilma", LastName = "Flintstone" },
                        Next = new Node
                        {
                            Value = new Person { FirstName = "Betty", LastName = "Rubble" },
                            Next = null
                        }
                    }
                }
            };

            PrintList(head);

            Node shortList = new Node
            {
                Value = new Person { FirstName = "Fred", LastName = "Flintstone" },
                Next = null
            };

            PrintList(shortList);

            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();

            Node bigHead = null;
            for (int i = 0; i < 10000; i++)
            {
                bigHead = new Node
                {
                    Value = new Person{FirstName = "Person #", LastName = i.ToString()},
                    Next = bigHead
                };
            }

            PrintList(bigHead);

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }

        private static void PrintList(Node head)
        {
            for (int i = 0; i < head.Count; i++)
            {
                Console.WriteLine(head.DescendantAt(i).Value.DisplayName);
            }

//            for (; head != null; head = head.Next)
//            {
//                Console.WriteLine(head.Value.DisplayName);
//            }

//            while (head != null)
//            {
//                Console.WriteLine(head.Value.DisplayName);
//                head = head.Next;
//            }
        }
    }
}
