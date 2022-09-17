using System;
using System.Collections.Generic;
using System.Text;

namespace Stack
{
    public interface IStack<T>
    {
        bool IsEmpty();
        T Pop();
        void Push(T element);
    }
}
