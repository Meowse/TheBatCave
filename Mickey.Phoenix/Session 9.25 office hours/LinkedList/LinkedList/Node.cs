using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class Node
    {
        public Person Value { get; set; }
        public Node Next { get; set; }
        public int Count
        {
            get
            {
                if (Next == null)
                {
                    return 1;
                }
                return Next.Count + 1;
            }
        }

        public Node DescendantAt(int i)
        {
            if (i == 0)
            {
                return this;
            }
            return Next.DescendantAt(i-1);
        }
    }
}
