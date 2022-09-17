using System;
using System.Collections.Generic;
using System.Text;

namespace Stack
{
    //Array Stack
    public class Stack<T> : IStack<T>
    {
        private int top = 0;
        private int size;
        private T[] stack;
        public Stack(int size = 10)
        {
            this.size = size;
            stack = new T[size];
        }
        public bool IsEmpty()
        {
            if (top == 0)
                return true;
            else
                return false;
        }
        public void Push(T element)
        {
            if (top > size)
                throw new Exception("Stack Overflow");
            stack[top] = element;
            top++;
        }
        public T Pop()
        {
            if (IsEmpty())
                throw new Exception("Stack Underflow");
            else
            {
                top--;
                return stack[top];
            }
        }
    }
}
