using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollections
{
    public class MyLinkedList<T> where T : IComparable<T>
    {
        MyLinkedListNode<T> first;
        MyLinkedListNode<T> last;
        int count;

        public MyLinkedList(T data):this(new MyLinkedListNode<T>(data))
        {            
        }
        public MyLinkedList(MyLinkedListNode<T> node)
        {
            first = last = node;
            count = 1;
        }
        public MyLinkedList()
        {
            first = last = null;
            count = 0;
        }

        public int Count
        { get { return this.count; } }

        // AddFirst, AddLast
        public void AddFirst(MyLinkedListNode<T> node)
        {
            if (count == 0)
            {
                first = last = node;
            }
            else
            {
                first.prev = node;
                node.next = first;
                first = node;
            }
            count++;
        }
        public void AddFirst(T data)
        {
            MyLinkedListNode<T> node = new MyLinkedListNode<T>(data);
            AddFirst(node);
        }
        public void AddLast(MyLinkedListNode<T> node)
        {
            if (count == 0)
            {
                first = last = node;
            }
            else
            {
                last.next = node;
                node.prev = last;
                last = node;
            }
            count++;
        }
        public void AddLast(T data)
        {
            MyLinkedListNode<T> node = new MyLinkedListNode<T>(data);
            AddLast(node);
        }
        // AddBefore, AddAfter
        public void AddAfter(MyLinkedListNode<T> afternode, MyLinkedListNode<T> node)
        {
            if (afternode.next == null)
            {
                AddLast(node);
            }
            else
            {
                afternode.next.prev = node;
                afternode.next = node;
                node.prev = afternode; 
                node.next = afternode.next;
                count++;
            }            
        }
        public void AddBefore(MyLinkedListNode<T> beforenode, MyLinkedListNode<T> node)
        {
            if (beforenode.prev == null)
            {
                AddFirst(node);
            }
            else
            {
                beforenode.prev.next = node;                
                node.prev = beforenode.prev;
                node.next = beforenode;
                beforenode.prev = node;
                count++;
            }  
        }
        // RemoveFirst, RemoveLast
        public void RemoveFirst()
        {
            if (Count == 0)
            {
                throw new Exception("Cannot remove from an empty list");
            }
            if(Count == 1)
            {
                first = last = null;
                count = 0;
            }
            else
            {
                first.next.prev = null;
                first = first.next;
                count--;
            }            
        }
        public void RemoveLast()
        {
            if (Count == 0)
            {
                throw new Exception("Cannot remove from an empty list");
            }
            if(Count == 1)
            {
                first = last = null;
                count = 0;
            }
            else
            {
                //last.prev.next = null;
                //last = last.prev;
                // or
                last = last.prev;
                last.next = null;
                count--;
            }            
        }
        // copy linked list to an array
        public T[] ToArray()
        {
            if (count == 0)
            {
                throw new Exception("List is empty");
            }
            T[] array = new T[Count];
            int index = 0;
            MyLinkedListNode<T> tempNode = first;
            while (tempNode != null)
            {
                array[index] = tempNode.data;
                tempNode = tempNode.next;
                index++;
            }
            return array;
        }
        // Contains (search)
        public bool Contains(MyLinkedListNode<T> node)
        {
            return false;
        }
        public bool Contains(T data)
        {
            MyLinkedListNode<T> tempNode = first;
            while (tempNode != null)
            {                
                if (tempNode.data.CompareTo(data) == 0)
                {
                    return true;
                }
                tempNode = tempNode.next;
            }
            return false;
        }
        public MyLinkedListNode<T> GetLinkedListNode(T data)
        {
            MyLinkedListNode<T> tempNode = first;
            while (tempNode != null)
            {
                tempNode = tempNode.next;
                if (tempNode.data.CompareTo(data) == 0)
                {
                    return tempNode;
                }
            }
            return null;
        }
    }
}
