using System;


namespace GenericCollections
{
    public class MyLinkedList<T> where T : IComparable<T>
    {
        MyLinkedListNode<T> _first;
        MyLinkedListNode<T> _last;
        int _count;

        public MyLinkedList(T data):this(new MyLinkedListNode<T>(data))
        {            
        }
        public MyLinkedList(MyLinkedListNode<T> node)
        {
            _first = _last = node;
            _count = 1;
        }
        public MyLinkedList()
        {
            _first = _last = null;
            _count = 0;
        }

        public int Count
        { get { return this._count; } }

        // AddFirst, AddLast
        public void AddFirst(MyLinkedListNode<T> node)
        {
            if (_count == 0)
            {
                _first = _last = node;
            }
            else
            {
                _first.prev = node;
                node.next = _first;
                _first = node;
            }
            _count++;
        }
        public void AddFirst(T data)
        {
            MyLinkedListNode<T> node = new MyLinkedListNode<T>(data);
            AddFirst(node);
        }
        public void AddLast(MyLinkedListNode<T> node)
        {
            if (_count == 0)
            {
                _first = _last = node;
            }
            else
            {
                _last.next = node;
                node.prev = _last;
                _last = node;
            }
            _count++;
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
                _count++;
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
                _count++;
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
                _first = _last = null;
                _count = 0;
            }
            else
            {
                _first.next.prev = null;
                _first = _first.next;
                _count--;
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
                _first = _last = null;
                _count = 0;
            }
            else
            {
                //last.prev.next = null;
                //last = last.prev;
                // or
                _last = _last.prev;
                _last.next = null;
                _count--;
            }            
        }
        // copy linked list to an array
        public T[] ToArray()
        {
            if (_count == 0)
            {
                throw new Exception("List is empty");
            }
            T[] array = new T[Count];
            int index = 0;
            MyLinkedListNode<T> tempNode = _first;
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
            MyLinkedListNode<T> tempNode = _first;
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
            MyLinkedListNode<T> tempNode = _first;
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
