using System;
using System.Collections.Generic;
using System.Text;

namespace Stack
{
    //Linked List Stack
    public class NodeStack<T> : IStack<T>
    {
        private Node top;
        private int size = 0;
        public int Size => size;
        public bool IsEmpty()
        {
            return top == null;
        }
        public void Push(T element)
        {
            Node node = new Node(element, top);
            top = node;
            size++;
        }

        public T Pop()
        {
            if (IsEmpty())
                throw new Exception("Stack Underflow");
            else
            {
                var temp = top.Element;
                top = top.Next;
                size--;
                return temp;
            }
        }
    }
