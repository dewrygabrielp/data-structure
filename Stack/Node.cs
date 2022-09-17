using System;
using System.Collections.Generic;
using System.Text;

namespace Stack
{
    public class Node
    {
        public Node(T element, Node next)
        {
            this.Element = element;
            this.Next = next;
        }
        public T Element { get; set; }
        public Node Next { get; set; }
    }
}
}
