using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollections
{
    public class MyLinkedListNode<T> where T:IComparable<T>
    {
        internal T data;
        internal MyLinkedListNode<T> next;
        internal MyLinkedListNode<T> prev;

        public MyLinkedListNode(T data)
        {
            this.data = data;
            next = prev = null;
        }
    }
}
