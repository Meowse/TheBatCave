using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GenericCollections;

namespace MyLinkedListTester
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            MyLinkedList<int> numbers = new MyLinkedList<int>();
            for(int i = 1; i<10; i++)
            {
                numbers.AddFirst(rand.Next(-100, 101));
            }
            numbers.AddFirst(1111); 
            numbers.AddLast(2222);
            
            Display(numbers);

            MyLinkedListNode<int> node = numbers.GetLinkedListNode(2222);
            numbers.AddBefore(node, new MyLinkedListNode<int>(5555));
            Display(numbers);
            numbers.AddAfter(node, new MyLinkedListNode<int>(5555));
            Display(numbers);
            numbers.AddFirst(4444);
            Display(numbers);
            numbers.AddLast(3333);
            Display(numbers);
            numbers.RemoveFirst();
            Display(numbers);
            numbers.RemoveLast();
            Display(numbers);
            Console.WriteLine();
            Console.WriteLine(numbers.Contains(1111).ToString());
            Console.WriteLine();
            Console.WriteLine(numbers.Contains(9999).ToString());

            Console.ReadLine();
        }
        static void Display(MyLinkedList<int> list)
        {
            Console.WriteLine("\n");
            int[] array = list.ToArray();
            foreach (int number in array)
            {
                Console.WriteLine("{0} ", number);
            }
        }
        

    }
}
